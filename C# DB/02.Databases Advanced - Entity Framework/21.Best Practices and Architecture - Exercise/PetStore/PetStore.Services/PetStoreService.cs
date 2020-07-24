namespace PetStore.Services
{
    using AutoMapper;
    using PetStore.Data;
    using PetStore.Models;
    using PetStore.ServiceModels.InputModels;
    using PetStore.Services.Interfaces;

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
            throw new System.NotImplementedException();
        }

        public bool Remove(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
