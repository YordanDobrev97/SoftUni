using System.Collections.Generic;

namespace SULS.ViewModels
{
    public class DetailsViewModel
    {
        public string Name { get; set; }

        public ICollection<DetailsProblemViewModel> Submissions { get; set; }
    }
}
