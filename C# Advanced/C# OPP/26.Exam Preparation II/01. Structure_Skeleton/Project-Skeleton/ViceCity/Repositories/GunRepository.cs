using System;
using System.Collections.Generic;
using System.Linq;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private List<IGun> guns;

        public GunRepository()
        {
            this.guns = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.guns.AsReadOnly();

        public void Add(IGun model)
        {
            if (!guns.Any(x => x.Name == model.Name))
            {
                guns.Add(model);
            }
        }

        public IGun Find(string name)
        {
            return this.guns.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IGun model)
        {
            return this.guns.Remove(model);
        }
    }
}
