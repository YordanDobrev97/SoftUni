namespace PetStore.Models
{
    using PetStore.Common;
    using PetStore.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.PetMaxLengthName)]
        [MinLength(Constants.PetMinLengthName)]
        public string Name { get; set; }

        [Required]
        [MaxLength(Constants.PetMaxAge)]
        [MinLength(Constants.PetMinAge)]
        public int Age { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public int? OwnerId { get; set; }

        public Owner Owner { get; set; }

        public bool IsSold { get; set; }
    }
}