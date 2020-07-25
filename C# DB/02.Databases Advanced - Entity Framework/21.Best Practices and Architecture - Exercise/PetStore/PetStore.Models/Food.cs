namespace PetStore.Models
{
    public class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? PetId { get; set; }

        public Pet Pet { get; set; }
    }
}
