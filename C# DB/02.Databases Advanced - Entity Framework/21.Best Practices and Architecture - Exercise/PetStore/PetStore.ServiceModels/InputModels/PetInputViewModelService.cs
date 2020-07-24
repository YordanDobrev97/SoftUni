namespace PetStore.ServiceModels.InputModels
{
    public class PetInputViewModelService
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public string Gender { get; set; }

        public int? OwnerId { get; set; }
    }
}