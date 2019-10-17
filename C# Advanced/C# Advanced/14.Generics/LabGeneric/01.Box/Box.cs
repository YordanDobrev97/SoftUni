using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> List { get; set; }

        public Box()
        {
            this.List = new List<T>();
        }

        public int Count { get; }

        public void Add(T element)
        {
            this.List.Add(element);
        }

        public T Remove()
        {
            int lastIndex = this.List.Count - 1;
            T top = this.List[lastIndex];

            this.List.RemoveAt(lastIndex);

            return top;
        }
    }
}
