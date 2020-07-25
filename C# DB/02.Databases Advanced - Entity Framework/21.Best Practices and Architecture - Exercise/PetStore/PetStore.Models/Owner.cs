namespace PetStore.Models
{
    using PetStore.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Owner
    {
        public Owner()
        {
            this.Pets = new HashSet<OwnerPets>();
            this.Toys = new HashSet<Toy>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.OwnerMaxLengthName)]
        [MinLength(Constants.OwnerMinLengthName)]
        public string Name { get; set; }

        public virtual ICollection<OwnerPets> Pets { get; set; }

        public virtual ICollection<Toy> Toys { get; set; }
    }
}