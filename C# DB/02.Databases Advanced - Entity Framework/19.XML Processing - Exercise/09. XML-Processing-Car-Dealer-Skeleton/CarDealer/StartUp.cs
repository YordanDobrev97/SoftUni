using CarDealer.Data;
using CarDealer.DTO.Export;
using CarDealer.DTO.Import;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using XmlFacade;

namespace CarDealer
{
    public class StartUp
    {
        private const string Path = "../../../Datasets";

        public static void Main()
        {
            var db = new CarDealerContext();

            var result = GetSalesWithAppliedDiscount(db);
            File.WriteAllText(Path + "/Output/sales-discounts.xml", result);
            //EnsureCreatedDatabase(db);
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new SaleInformationDTO
                {
                    Car = new SaleCarDTO
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    },
                    Discount = s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartCars.Sum(pc => pc.Part.Price),
                    PriceWithDiscount =
                              s.Car.PartCars.Sum(pc => pc.Part.Price) - (s.Car.PartCars.Sum(pc => pc.Part.Price) * s.Discount / 100)

                })
                .ToArray();

            var root = "sales";
            var xml = XmlConverter.Serialize(sales, root);
            return xml;
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new ExportCustomerSalesDTO
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(pc => pc.Part.Price))
                })
                .OrderByDescending(c => c.SpentMoney)
                .ToArray();

            var root = "customers";
            var xml = XmlConverter.Serialize(customers, root);
            return xml;
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars.Select(c => new ExportCarPartsDTO
            {
                Make = c.Make,
                Model = c.Model,
                TravelledDistance = c.TravelledDistance,
                Parts = c.PartCars.Select(pc => new ExportPartDTO
                {
                    Name = pc.Part.Name,
                    Price = pc.Part.Price
                })
                .OrderByDescending(pc => pc.Price)
                .ToArray()
            })
            .OrderByDescending(c => c.TravelledDistance)
            .ThenBy(c => c.Model)
            .Take(5)
            .ToArray();

            var root = "cars";
            var xml = XmlConverter.Serialize(cars, root);
            return xml;
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => !s.IsImporter)
                .Select(s => new ExportSupplierDTO
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count(p => p.Quantity > 0)
                })
                .ToArray();

            var root = "suppliers";
            var xml = XmlConverter.Serialize(suppliers, root);

            return xml;
        }

        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "BMW")
                .Select(c => new ExportCarMakeBmwDTO
                {
                    Id = c.Id,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .ToArray();

            var root = "cars";
            var xml = XmlConverter.Serialize(cars, root);
            return xml;
        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.TravelledDistance > 2_000_000)
                .Select(c => new ExportCarDistanceDTO
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .ToArray();

            
            var root = "cars";
            var xml = XmlConverter.Serialize(cars, root);

            return xml;
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            var root = "Sales";
            var data = XmlConverter.Deserializer<ImportSaleDTO>(inputXml, root);

            List<Sale> sales = new List<Sale>();
            foreach (var saleDTO in data)
            {
                var existCar = context.Cars.Any(c => c.Id == saleDTO.CarId);

                if (!existCar)
                {
                    continue;
                }

                var sale = new Sale
                {
                    CarId = saleDTO.CarId,
                    CustomerId = saleDTO.CustomerId,
                    Discount = saleDTO.Discount
                };

                sales.Add(sale);
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            var root = "Customers";
            var data = XmlConverter.Deserializer<CustomerDTO>(inputXml, root);

            var customers = data.Select(c => new Customer
            {
                Name = c.Name,
                BirthDate = DateTime.Parse(c.BirthDate),
                IsYoungDriver = c.IsYoungDriver
            })
            .ToArray();

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Length}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var root = "Cars";
            var dataCars = XmlConverter.Deserializer<CarDTO>(inputXml, root);

            var cars = new List<Car>();
            foreach (var carDTO in dataCars)
            {
                var uniqueParts = carDTO.Parts.Select(p => p.partId).Distinct().ToArray();
                var realParts = uniqueParts.Where(id => context.Parts.Any(i => i.Id == id));

                var car = new Car
                {
                    Make = carDTO.Make,
                    Model = carDTO.Model,
                    TravelledDistance = carDTO.TraveledDistance,
                    PartCars = realParts.Select(id => new PartCar
                    {
                        PartId = id
                    })
                    .ToArray()
                };
                cars.Add(car);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var root = "Parts";
            var data = XmlConverter.Deserializer<ImportPartDTO>(inputXml, root);

            var parts = data
                .Where(p => context.Suppliers.Any(s => s.Id == p.SupplierId))
                .Select(p => new Part
            {
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                SupplierId = p.SupplierId
            })
            .ToArray();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Length}";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var root = "Suppliers";
            var data = XmlConverter.Deserializer<ImportSupplierDTO>(inputXml, root);

            var suppliers = data.Select(s => new Supplier
            {
                Name = s.Name,
                IsImporter = s.IsImporter
            })
            .ToArray();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Length}";
        }

        public static void EnsureCreatedDatabase(CarDealerContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            Console.WriteLine("Database was created!");
        }
    }
}