namespace ConsoleApp
{
    using AutoMapper;
    using PetStore.Data;
    using PetStore.Models.Enums;
    using PetStore.ServiceModels.InputModels;
    using PetStore.Services;
    using PetStore.Services.Interfaces;
    using PetStore.Services.Mapping;
    using System;

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

            bool result =petService.Remove(2);
            Console.WriteLine(result);
        }
    }
}