namespace PetStore.Models
{
    public class OwnerPets
    {
        public int OwnerId { get; set; }

        public Owner Owner { get; set; }

        public int PetId { get; set; }

        public Pet Pet { get; set; }

        public decimal Price { get; set; }
    }
}