using System.Collections.Generic;
using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.Models
{
    public class AddCollection<T> : IAddCollection<T>, IMyCollection<T>
    {
        public AddCollection()
        {
            this.Used = new List<T>();
        }

        public List<T> Used { get; }

        public void Add(T item)
        {
            this.Used.Add(item);
        }
    }
}
