namespace PetStore.Services
{
    using AutoMapper;
    using PetStore.Common;
    using PetStore.Data;
    using PetStore.Models;
    using PetStore.ServiceModels.InputModels;
    using PetStore.Services.Interfaces;
    using System;
    using System.Linq;

    public class OwnerService : IOwnerService
    {
        private readonly PetStoreDbContext db;
        private readonly IMapper mapper;

        public OwnerService(PetStoreDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void CreateOwner(OwnerInputViewModelService model)
        {
            var owner = this.mapper.Map<Owner>(model);

            this.db.Owners.Add(owner);
            this.db.SaveChanges();
        }

        /// <summary>
        /// Throw Exception if not exist pet otherwise buy pet
        /// </summary>
        /// <param name="model"></param>
        public void BuyPet(PetInputViewModelService model)
        {
            var pet = db.Pets.FirstOrDefault(p => p.Id == model.Id);

            if (pet == null)
            {
                throw new ArgumentException(Constants.NotExistMessage);
            }

            var owner = db.Owners.FirstOrDefault(o => o.Id == model.OwnerId);

            if (owner == null)
            {
                throw new ArgumentException(String.Format(Constants.NotExistMessage, "Owner"));
            }

            pet.OwnerId = owner.Id;
            var ownerPet = new OwnerPets
            {
                OwnerId = owner.Id,
                PetId = pet.Id
            };

            owner.Pets.Add(ownerPet);
            this.db.SaveChanges();
        }

        public void FeedPet(Pet pet, Food food)
        {
            pet.QuantityFood += food.Quantity;
            pet.Foods.Add(food);
            this.db.SaveChanges();
        }

        public void BuyProduct(ProductInputViewModelService model)
        {
            Owner ownerId = ExistOwner(model.OwnerId);

            if (ownerId == null)
            {
                throw new ArgumentException();
            }

            var product = new Product
            {
                Name = model.Name,
                Price = model.Price,
                OwnerId = model.OwnerId
            };

            this.db.Products.Add(product);
            this.db.SaveChanges();
        }

        public void BuyToy(ToyInputViewModelService model)
        {
            var owner = ExistOwner(model.OwnerId);

            if (owner == null)
            {
                throw new ArgumentException();
            }

            var toy = new Toy
            {
                Name = model.Name,
                Price = model.Price,
                OwnerId = model.OwnerId
            };

            this.db.Toys.Add(toy);
            this.db.SaveChanges();
        }

        private Owner ExistOwner(int id)
        {
            return this.db.Owners.FirstOrDefault(o => o.Id == id);
        }
    }
}