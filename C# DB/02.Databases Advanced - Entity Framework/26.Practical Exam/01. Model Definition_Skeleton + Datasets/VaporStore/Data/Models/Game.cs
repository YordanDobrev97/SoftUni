﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VaporStore.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.GameTags = new HashSet<GameTag>();
            this.Purchases = new HashSet<Purchase>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Developer")]
        public int DeveloperId { get; set; }

        public Developer Developer { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

        public virtual ICollection<GameTag> GameTags { get; set; }
    }
}
