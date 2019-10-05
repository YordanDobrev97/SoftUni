using System.Collections.Generic;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;
        private int id;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
        }

        public int Count => this.data.Count;

        public void Add(Person person)
        {
            this.data.Add(id, person);
            id++;
        }

        public Person Get(int id)
        {
            var person = this.data[id];

            return person;
        }

        public bool Update(int id, Person newPerson)
        {
            var isContainsPerson = this.data.ContainsKey(id);

            if (isContainsPerson)
            {
                this.data[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var isContains = this.data.ContainsKey(id);

            if (isContains)
            {
                this.data.Remove(id);
                return true;
            }

            return false;
        }
    }
}
