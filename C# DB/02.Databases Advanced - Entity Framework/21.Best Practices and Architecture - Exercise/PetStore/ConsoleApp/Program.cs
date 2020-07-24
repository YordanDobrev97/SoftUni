namespace ConsoleApp
{
    using AutoMapper;
    using PetStore.Data;
    using PetStore.Models.Enums;
    using PetStore.ServiceModels.InputModels;
    using PetStore.Services;
    using PetStore.Services.Interfaces;
    using PetStore.Services.Mapping;

    public class Program
    {
        public static void Main()
        {
            var db = new PetStoreDbContext();
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<PetStoreProfile>();
            });

            IMapper mapper = new Mapper(config);
            IPetService petService = new PetStoreService(db, mapper);
            IOwnerService ownerService = new OwnerService(db, mapper);

            var inputOwnerModel = new OwnerInputViewModelService
            {
                Name = "Pesho"
            };

            ownerService.CreateOwner(inputOwnerModel);

            var inputModel = new PetInputViewModelService
            {
                Id = 1,
                Name = "Sharo",
                Age = 3,
                Breed = "sweet cat breed",
                Gender = "Female",
                OwnerId = 1
            };

            ownerService.BuyPet(inputModel);
        }
    }
}
