using SULS.Services;
using SULS.ViewModels;
using SUS.HTTP;
using SUS.MvcFramework;
using System.Collections.Generic;

namespace SULS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProblemsService problemsService;

        public HomeController(IProblemsService problemsService)
        {
            this.problemsService = problemsService;
        }

        [HttpGet("/")]
        public HttpResponse Index()
        {
            if (this.IsUserSignedIn())
            {
                var problems = this.problemsService.All();
                return this.View(problems, "IndexLoggedIn");
            }

            return this.View();
        }
    }
}
