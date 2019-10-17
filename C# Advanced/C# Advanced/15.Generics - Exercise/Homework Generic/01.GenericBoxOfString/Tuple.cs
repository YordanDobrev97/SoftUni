using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class CustomTuple<T1, T2>
    {
        private KeyValuePair<T1, T2> pairs;
        
        public CustomTuple(T1 firstObject, T2 secondObject)
        {
            this.pairs = new KeyValuePair<T1, T2>(firstObject, secondObject);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{pairs.Key} -> {pairs.Value}");

            return result.ToString();
        }
    }
}
