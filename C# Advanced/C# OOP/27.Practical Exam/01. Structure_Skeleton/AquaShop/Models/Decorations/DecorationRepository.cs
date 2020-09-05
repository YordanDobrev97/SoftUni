using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquaShop.Models.Decorations
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> models;

        public DecorationRepository()
        {
            this.models = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => this.models.AsReadOnly();

        public void Add(IDecoration model)
        {
            this.models.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            var decoration = this.models.FirstOrDefault(x => x.GetType().Name == type);

            return decoration;
        }

        public bool Remove(IDecoration model)
        {
            return this.models.Remove(model);
        }
    }
}
