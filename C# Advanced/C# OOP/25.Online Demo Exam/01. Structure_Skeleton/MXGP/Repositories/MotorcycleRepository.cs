using MXGP.Models.Motorcycles.Contracts;
using System.Linq;

namespace MXGP.Repositories
{
    public class MotorcycleRepository : Repository<IMotorcycle>
    {
        public override IMotorcycle GetByName(string name)
        {
            return this.ListModels.FirstOrDefault(x => x.Model == name);
        }
    }
}
