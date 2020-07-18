using System.IO;
using System.Linq;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        private const string DefaultPath = "../../../Datasets";

        public static void Main()
        {
            var db = new CarDealerContext();
            var result = GetSalesWithAppliedDiscount(db);
            File.WriteAllText(DefaultPath + "/Results/sales-discounts.json", result);

            //EnsureCreatedDatabase(db);
        }

        public static void EnsureCreatedDatabase(CarDealerContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }

        //09.ImportSuppliers
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            Supplier[] suppliers = JsonConvert.DeserializeObject<Supplier[]>(inputJson);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();


            return $"Successfully imported {suppliers.Length}.";
        }

        //10.ImportParts
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            Part[] parts = JsonConvert.DeserializeObject<Part[]>(inputJson)
                .Where(p => context.Suppliers.Any(s => s.Id == p.SupplierId))
                .ToArray();

            context.AddRange(parts);

            context.SaveChanges();

            return $"Successfully imported {parts.Length}.";
        }

        //11.ImportCars
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            CarDTO[] cars = JsonConvert.DeserializeObject<CarDTO[]>(inputJson);

            foreach (var car in cars)
            {
                var newCar = new Car
                {
                    Make = car.Make,
                    Model =car.Model,
                    TravelledDistance = car.TravelledDistance
                };

                context.Cars.Add(newCar);

                foreach (var part in car.Parts)
                {
                    var carPart = new PartCar
                    {
                        CarId = newCar.Id,
                        PartId = part
                    };

                    if (!newCar.PartCars.Any(pc => pc.PartId == carPart.PartId))
                    {
                        context.PartCars.Add(carPart);
                    }
                }
            }

            context.SaveChanges();

            return $"Successfully imported {cars.Length}.";
        }

        //12.ImportCustomers
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            Customer[] customers = JsonConvert.DeserializeObject<Customer[]>(inputJson);

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Length}.";
        }

        //13.ImportSales
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            Sale[] sales = JsonConvert.DeserializeObject<Sale[]>(inputJson);

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Length}.";
        }

        //14.GetOrderedCustomers
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy"),
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToList();

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(customers, settings);

            return json;
        }

        //15.GetCarsFromMakeToyota
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .ToList();

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(cars, settings);
            return json;
        }

        //16.GetLocalSuppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
           var suppliers = context.Suppliers
                .Where(s => !s.IsImporter)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToList();

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(suppliers, settings);
            return json;
        }

        //17.GetCarsWithTheirListOfParts
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars.Select(c => new
            {
                Car = new 
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                },
                Parts = c.PartCars.Select(pc => new
                {
                    Name = pc.Part.Name,
                    Price = pc.Part.Price.ToString("F2")
                })
            }).ToList();

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(cars, settings);
            return json;
        }

        //18.GetTotalSalesByCustomer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
           var customers = context.Customers
                .Where(c => c.Sales.Any(s => s.Car != null))
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count,
                    spentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(pc => pc.Part.Price))
                })
                .ToList();

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(customers, settings);
            return json;
        }

        //19.GetSalesWithAppliedDiscount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new
                {
                    Car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    },
                    CustomerName = s.Customer.Name,
                    Discount = s.Discount.ToString("F2"),
                    Price = s.Car.PartCars.Sum(pc => pc.Part.Price).ToString("F2"),
                    PriceWithDiscount = 
                            (s.Car.PartCars.Sum(pc => pc.Part.Price) - s.Discount / 100).ToString("F2")
                })
                .ToList();

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(sales, settings);
            return json;
        }
    }
}