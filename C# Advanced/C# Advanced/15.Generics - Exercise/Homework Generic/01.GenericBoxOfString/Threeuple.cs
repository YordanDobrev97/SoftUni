using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Threeuple<T1,T2,T3>
    {
        private T1 firstObject;
        private T2 secondObject;
        private T3 thirdObject;

        public Threeuple(T1 firstObject, T2 secondObject, T3 thirdObject)
        {
            this.firstObject = firstObject;
            this.secondObject = secondObject;
            this.thirdObject = thirdObject;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{firstObject} -> {secondObject} -> {thirdObject}");

            return result.ToString();
        }
    }
}
