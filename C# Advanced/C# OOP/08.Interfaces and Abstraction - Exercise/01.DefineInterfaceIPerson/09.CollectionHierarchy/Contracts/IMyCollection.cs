using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public interface IMyCollection<T>
    {
        public List<T> Used { get; }
    }
}
