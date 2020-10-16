using SULS.Data;
using SULS.Models;
using System;
using System.Linq;

namespace SULS.Services
{
    public class SubmissionsService : ISubmissionsService
    {
        private readonly ApplicationDbContext db;
        private readonly Random random;

        public SubmissionsService(ApplicationDbContext db, Random random)
        {
            this.db = db;
            this.random = random;
        }

        public void Create(string userId, string code, string problemId)
        {
            int countProblems = this.db.Problems.Count();

            this.db.Submissions.Add(new Submission
            {
                UserId = userId,
                Code = code,
                ProblemId = problemId,
                Created = DateTime.UtcNow,
                AchievedResult = random.Next(0, countProblems + 1)
            });

            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            var submission = this.db.Submissions.Find(id);

            this.db.Submissions.Remove(submission);
            this.db.SaveChanges();
        }
    }
}
