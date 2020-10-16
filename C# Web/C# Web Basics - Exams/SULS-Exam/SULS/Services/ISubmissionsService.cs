using SULS.ViewModels;

namespace SULS.Services
{
    public interface ISubmissionsService
    {
        void Create(string userId, string code, string problemId);

        void Delete(string id);
    }
}
