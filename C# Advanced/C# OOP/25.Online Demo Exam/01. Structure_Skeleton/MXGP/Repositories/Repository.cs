using MXGP.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace MXGP.Repositories
{
    public abstract class Repository<T> : IRepository<T>
    {
        private List<T> models;

        public Repository()
        {
            this.models = new List<T>();
        }

        public IReadOnlyCollection<T> ListModels => this.models.AsReadOnly();

        public void Add(T model)
        {
            this.models.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return this.models.AsReadOnly();
        }

        public abstract T GetByName(string name);

        public bool Remove(T model)
        {
            return this.models.Remove(model);
        }
    }
}
