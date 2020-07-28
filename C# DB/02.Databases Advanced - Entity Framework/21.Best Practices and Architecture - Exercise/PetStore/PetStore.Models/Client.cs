using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PetStore.Common;

namespace PetStore.Models
{
    public class Client
    {
        public Client()
        {
            this.Pets = new HashSet<Pet>();
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(Constants.MinLengthUsername)]
        [MaxLength(Constants.MaxLengthUsername)]
        public string Username { get; set; }

        [Required]
        [MinLength(Constants.MinLengthPassword)]
        [MaxLength(Constants.MaxLengthPassword)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}