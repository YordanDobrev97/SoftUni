namespace PetStore.Services.Interfaces
{
    using PetStore.Models;
    using PetStore.ServiceModels.InputModels;

    public interface IPetService
    {
        void AddPet(PetInputViewModelService model);

        Pet GetPetById(int id);

        void Eat(int id, int quantity);

        bool Remove(int id);

        bool Remove(string name);
    }
}
