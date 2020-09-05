using System.Collections.Generic;
using System.Linq;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    class GunRepository : IRepository<IGun>
    {
        private List<IGun> models;

        public IReadOnlyCollection<IGun> Models => this.models.AsReadOnly();

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public void Add(IGun model)
        {
            if (!this.models.Any(x => x.Name == model.Name))
            {
                this.models.Add(model);
            }
        }

        public IGun Find(string name)
        {
            var gun = this.models.FirstOrDefault(x => x.Name == name);

            return gun;
        }

        public bool Remove(IGun model)
        {
            var gun = this.models.FirstOrDefault(x => x.Name == model.Name);

            return this.models.Remove(gun);
        }
    }
}
