using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> values;

        public Box()
        {
            this.values = new List<T>();
        }

        public List<T> Values => this.values;

        public void Add(T value)
        {
            this.values.Add(value);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (IsValidIndex(firstIndex) && IsValidIndex(secondIndex))
            {
                T temp = this.values[firstIndex];
                this.values[firstIndex] = this.values[secondIndex];
                this.values[secondIndex] = temp;
            }
        }

        public int GetCountGratherElement(T element)
        {
            int count = 0;

            foreach (var value in this.Values)
            {
                if (IsGreaterThanElement(value, element))
                {
                    count++;
                }
            }

            return count;
        }

        public bool IsGreaterThanElement(T element, T elementInput)
        {
            int compare = element.CompareTo(elementInput);

            return compare > 0;
        }

        private bool IsValidIndex(int index)
        {
            return !(index < 0 || index > this.Values.Count - 1);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var value in values)
            {
                result.AppendLine($"{value.GetType()}: {value}");
            }

            return result.ToString();
        }
    }
}
