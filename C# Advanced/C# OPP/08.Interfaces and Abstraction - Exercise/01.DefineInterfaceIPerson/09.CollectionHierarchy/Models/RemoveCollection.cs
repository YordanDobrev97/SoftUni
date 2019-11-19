using System.Collections.Generic;
using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.Models
{
    public class RemoveCollection<T> : IRemoveCollection<T>, IMyCollection<T>, IAddCollection<T>
    {
        public RemoveCollection()
        {
            this.Used = new List<T>();
        }

        public List<T> Used { get; }

        public void Add(T item)
        {
            this.Used.Insert(0, item);
        }

        public void Remove()
        {
            this.Used.RemoveAt(this.Used.Count - 1);
        }
    }
}
