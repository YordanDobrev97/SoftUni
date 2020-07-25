namespace PetStore.Models
{
    public class Toy
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? OwnerId { get; set; }

        public Owner Owner { get; set; }
    }
}