using MXGP.Models.Riders.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace MXGP.Repositories
{
    public class RiderRepository : Repository<IRider>
    {
        public override IRider GetByName(string name)
        {
            return this.ListModels.FirstOrDefault(x => x.Name == name);
        }
    }
}
