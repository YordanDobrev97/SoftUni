using System;

namespace SULS.ViewModels
{
    public class DetailsProblemViewModel
    {
        public string Name { get; set; }

        public int AchievedResult { get; set; }

        public int MaxPoints { get; set; }

        public string CreatedOn { get; set; }

        public string SubmissionId { get; set; }
    }
}
