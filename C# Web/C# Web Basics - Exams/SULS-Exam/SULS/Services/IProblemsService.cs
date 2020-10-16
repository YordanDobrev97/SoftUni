using SULS.ViewModels;
using System.Collections.Generic;

namespace SULS.Services
{
    public interface IProblemsService
    {
        void Create(string name, int points);

        List<ListProblemsViewModel> All();

        SubmissionViewModel GetById(string id);

        DetailsViewModel Details(string id);
    }
}
