using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();
        public string RandomString()
        {
            int randomIndex = GetRandomIndex();
            string randomElement = this[randomIndex];
            return randomElement;
        }

        public string RemoveRandomString()
        {
            int randomIndex = GetRandomIndex();
            string randomElement = this[randomIndex];
            this.RemoveAt(randomIndex);
            return randomElement;
        }

        private int GetRandomIndex()
        {
            return random.Next(0, this.Count);
        }
    }
}
