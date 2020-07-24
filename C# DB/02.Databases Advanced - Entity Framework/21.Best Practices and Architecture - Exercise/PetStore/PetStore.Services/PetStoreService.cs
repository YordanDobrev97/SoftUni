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

    public class PetStoreService : IPetService
    {
        private readonly IMapper mapper;
        private readonly PetStoreDbContext db;

        public PetStoreService(PetStoreDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddPet(PetInputViewModelService model)
        {
            var pet = this.mapper.Map<Pet>(model);

            db.Pets.Add(pet);
            db.SaveChanges();
        }

        public bool Remove(int id)
        {
            var pet = this.db.Pets.FirstOrDefault(p => p.Id == id);

            if (pet == null)
            {
                throw new ArgumentException(String.Format(Constants.NotExistMessage, "Pet"));
            }

            this.db.Pets.Remove(pet);
            int affected = this.db.SaveChanges();

            return affected == 1;
        }

        public bool Remove(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}