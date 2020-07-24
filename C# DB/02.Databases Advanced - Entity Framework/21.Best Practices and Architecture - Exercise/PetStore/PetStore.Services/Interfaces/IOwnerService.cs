namespace PetStore.Services.Interfaces
{
    using PetStore.ServiceModels.InputModels;

    public interface IOwnerService
    {
        void CreateOwner(OwnerInputViewModelService model);

        void BuyPet(PetInputViewModelService model);
    }
}
