using SULS.Services;
using SUS.HTTP;
using SUS.MvcFramework;
using System;

namespace SULS.Controllers
{
    public class ProblemsController : Controller
    {
        private readonly IProblemsService problemsService;
        
        public ProblemsController(IProblemsService problemsService)
        {
            this.problemsService = problemsService;
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
        public HttpResponse Create(string name, int points)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 5
                || name.Length > 20)
            {
                return this.Error("Invalid problem name");
            }

            if (points < 50 ||  points > 300)
            {
                return this.Error("Invalid problem points");
            }

            this.problemsService.Create(name, points);
            return this.Redirect("/");
        }

        public HttpResponse Details(string id)
        {
            var sumbissions = this.problemsService.Details(id);
            return this.View(sumbissions);
        }
    }
}
