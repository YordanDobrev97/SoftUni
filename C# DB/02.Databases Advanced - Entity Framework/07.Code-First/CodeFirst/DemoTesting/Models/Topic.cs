using System.ComponentModel.DataAnnotations;

namespace DemoTesting.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
