namespace PetStore.Services.Interfaces
{
    using PetStore.Models;

    public interface IFoodService
    {
        Food GetFoodById(int id);

        Food GetFoodByName(string name);
    }
}
