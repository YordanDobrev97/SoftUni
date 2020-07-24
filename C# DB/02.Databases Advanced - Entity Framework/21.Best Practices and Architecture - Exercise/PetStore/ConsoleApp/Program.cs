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

            var inputModel = new PetInputViewModelService
            {
                Name = "Sharo",
                Age = 3,
                Breed = "sweet cat breed",
                Gender = "Female"
            };

            petService.AddPet(inputModel);
        }
    }
}
