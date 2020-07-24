namespace PetStore.Services.Interfaces
{
    using PetStore.ServiceModels.InputModels;

    public interface IPetService
    {
        void AddPet(PetInputViewModelService model);

        bool Remove(int id);

        bool Remove(string name);
    }
}
