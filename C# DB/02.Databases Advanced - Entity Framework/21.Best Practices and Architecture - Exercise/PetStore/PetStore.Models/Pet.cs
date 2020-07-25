namespace PetStore.Models
{
    using PetStore.Common;
    using PetStore.Models.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Pet
    {
        public Pet()
        {
            this.Foods = new HashSet<Food>();
        }

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

        public int QuantityFood { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}