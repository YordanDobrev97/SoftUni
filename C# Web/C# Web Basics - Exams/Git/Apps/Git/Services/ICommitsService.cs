using Git.ViewModels.Commits;
using System.Collections.Generic;

namespace Git.Services
{
    public interface ICommitsService
    {
        void Create(string userId, string repositoryId, string description);

        List<AllCommitsViewModel> All(string userId);

        void Delete(string id, string userId);
    }
}
