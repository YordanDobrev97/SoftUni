﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SULS.Models
{
    public class Submission
    {
        public Submission()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(800)]
        public string Code { get; set; }

        public int AchievedResult { get; set; }

        public DateTime Created { get; set; }

        public string ProblemId { get; set; }

        public Problem Problem { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
