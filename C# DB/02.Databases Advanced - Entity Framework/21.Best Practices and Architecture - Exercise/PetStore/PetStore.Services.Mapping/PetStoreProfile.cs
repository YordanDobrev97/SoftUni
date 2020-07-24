namespace PetStore.Services.Mapping
{
    using AutoMapper;
    using PetStore.Models;
    using PetStore.ServiceModels.InputModels;

    public class PetStoreProfile : Profile
    {
        public PetStoreProfile()
        {
            this.CreateMap<PetInputViewModelService, Pet>();
        }
    }
}
