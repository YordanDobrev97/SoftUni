using Git.Data;
using Git.ViewModels.Commits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Git.Services
{
    public class CommitsService : ICommitsService
    {
        private readonly ApplicationDbContext db;

        public CommitsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<AllCommitsViewModel> All(string userId)
        {
            var commits = this.db.Commits
                .Where(x => x.User.Id == userId)
                .Select(e => new AllCommitsViewModel
            {
                Id = e.Id,
                Repository = e.Repository.Name,
                CreatedOn = e.CreatedOn.ToString(),
                Description = e.Description
            }).ToList();

            return commits;
        }

        public void Create(string userId, string repositoryId, string description)
        {
            var commit = new Commit
            {
                CreatedOn = DateTime.UtcNow,
                CreatorId = userId,
                RepositoryId = repositoryId,
                Description = description
            };

            this.db.Commits.Add(commit);
            this.db.SaveChanges();
        }

        public void Delete(string id, string userId)
        {
            var commit = this.db.Commits
                .Where(x => x.Id == id && x.User.Id == userId)
                .FirstOrDefault();

            this.db.Commits.Remove(commit);
            this.db.SaveChanges();
        }
    }
}
