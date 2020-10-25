using Git.Services;
using SUS.HTTP;
using SUS.MvcFramework;

namespace Git.Controllers
{
    public class RepositoriesController : Controller
    {
        private readonly IRepositoriesService repositoriesService;

        public RepositoriesController(IRepositoriesService repositoriesService)
        {
            this.repositoriesService = repositoriesService;
        }

        public HttpResponse All()
        {
            var userId = this.GetUserId();
            var all = this.repositoriesService.All(userId);
            return this.View(all);
        }

        public HttpResponse Create()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Create(string name, string repositoryType)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (string.IsNullOrWhiteSpace(name) 
                || name.Length < 3
                || name.Length > 10)
            {
                return this.Error("Invalid repository name.");
            }

            bool isPublic = repositoryType == "Public";
            var user = this.GetUserId();

            this.repositoriesService.Create(user, name, isPublic);
            return this.Redirect("/Repositories/All");
        }
    }
}
