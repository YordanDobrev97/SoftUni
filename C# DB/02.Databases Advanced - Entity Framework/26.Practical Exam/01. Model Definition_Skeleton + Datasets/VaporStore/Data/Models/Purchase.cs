using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VaporStore.Data.Models.Enums;

namespace VaporStore.Data.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        public PurchaseType Type { get; set; }

        [Required]
        public string ProductKey { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("Card")]
        [Required]
        public int CardId { get; set; }

        public Card Card { get; set; }

        [ForeignKey("Game")]
        [Required]
        public int GameId { get; set; }

        public Game Game { get; set; }
    }
}
