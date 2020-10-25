using Git.ViewModels.Repositories;
using System.Collections.Generic;

namespace Git.Services
{
    public interface IRepositoriesService
    {
        List<AllRepositoriesViewModel> All(string userId);

        void Create(string userId, string name, bool isPublicRepository);

        RepositoryViewModel GetById(string id);
    }
}
