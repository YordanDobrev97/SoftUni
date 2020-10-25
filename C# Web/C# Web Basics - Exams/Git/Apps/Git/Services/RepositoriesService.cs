using Git.Data;
using Git.ViewModels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Git.Services
{
    public class RepositoriesService : IRepositoriesService
    {
        private readonly ApplicationDbContext db;

        public RepositoriesService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<AllRepositoriesViewModel> All(string userId)
        {
            var result = this.db.Repositories
                .Where(x => x.OwnerId == userId 
                ? x.IsPublic || !x.IsPublic
                : x.IsPublic)
                .Select(e => new AllRepositoriesViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Owner = e.User.Username,
                    CreatedOn = e.CreatedOn.ToString(),
                    CommitsCount = e.Commits.Count,
                }).ToList();

            return result;
        }

        public void Create(string userId, string name, bool isPublicRepository)
        {
            var repository = new Repository
            {
                Name = name,
                IsPublic = isPublicRepository,
                CreatedOn = DateTime.UtcNow,
                OwnerId = userId,
            };

            this.db.Repositories.Add(repository);
            this.db.SaveChanges();
        }

        public RepositoryViewModel GetById(string id)
        {
            var repository = this.db.Repositories.Where(x => x.Id == id)
                .Select(e => new RepositoryViewModel
                {
                    Name = e.Name,
                    Id = e.Id
                }).FirstOrDefault();

            return repository;
        }
    }
}
