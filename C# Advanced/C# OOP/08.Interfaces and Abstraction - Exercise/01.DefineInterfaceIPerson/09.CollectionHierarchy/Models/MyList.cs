using System.Collections.Generic;
using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.Models
{
    public class MyList<T> : IMyList<T>
    {
        private List<T> items;

        public MyList()
        {
            this.items = new List<T>();
        }

        public List<T> Used
        {
            get => this.items;
        }

        public void Add(T item)
        {
            this.items.Insert(0, item);
        }

        public void Remove()
        {
            this.items.RemoveAt(0);
        }
    }
}
