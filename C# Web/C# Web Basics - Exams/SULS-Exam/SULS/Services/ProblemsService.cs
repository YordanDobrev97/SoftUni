using SULS.Data;
using SULS.Models;
using SULS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SULS.Services
{
    public class ProblemsService : IProblemsService
    {
        private readonly ApplicationDbContext db;

        public ProblemsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<ListProblemsViewModel> All()
        {
            return this.db.Problems.Select(e => new ListProblemsViewModel
            {
                Name = e.Name,
                Id = e.Id,
                Count = e.Submissions.Count
            }).ToList();
        }

        public void Create(string name, int points)
        {
            this.db.Problems.Add(new Problem
            {
                Name = name,
                Points = points
            });

            this.db.SaveChanges();
        }

        public DetailsViewModel Details(string id)
        {
            var submissions = this.db.Submissions.Where(x => x.ProblemId == id)
                .Select(e => new DetailsProblemViewModel
                {
                    Name = e.User.Username,
                    AchievedResult = e.AchievedResult,
                    MaxPoints = e.Problem.Points,
                    CreatedOn = e.Created.ToString("dd/MM/yyyy"),
                    SubmissionId = e.Id
                }).ToList();

            var problemName = this.db.Problems.Where(x => x.Id == id).FirstOrDefault();
            var viewModel = new DetailsViewModel
            {
                Name = problemName.Name,
                Submissions = submissions,
            };

            return viewModel;
        }

        public SubmissionViewModel GetById(string id)
        {
            var problem = this.db.Problems.Where(p => p.Id == id).FirstOrDefault();

            return new SubmissionViewModel
            {
                Name = problem.Name,
                ProblemId = problem.Id
            };
        }
    }
}
