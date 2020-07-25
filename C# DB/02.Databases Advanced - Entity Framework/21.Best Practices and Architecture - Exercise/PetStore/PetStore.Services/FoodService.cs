namespace PetStore.Services
{
    using PetStore.Data;
    using PetStore.Models;
    using PetStore.Services.Interfaces;
    using System.Linq;

    public class FoodService : IFoodService
    {
        private readonly PetStoreDbContext db;

        public FoodService(PetStoreDbContext db)
        {
            this.db = db;
        }

        public Food GetFoodById(int id)
        {
            var food = this.db.Foods.FirstOrDefault(f => f.Id == id);
            return food;
        }

        public Food GetFoodByName(string name)
        {
            var food = this.db.Foods.FirstOrDefault(f => f.Name == name);
            return food;
        }
    }
}