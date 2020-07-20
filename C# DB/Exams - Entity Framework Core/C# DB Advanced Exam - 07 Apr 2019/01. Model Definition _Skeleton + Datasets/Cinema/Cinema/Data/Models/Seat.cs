using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Data.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Hall")]
        public int HallId { get; set; }

        public Hall Hall { get; set; }
    }
}