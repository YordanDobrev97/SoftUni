using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Persons { get; set; }

        public Family()
        {
            this.Persons = new List<Person>();
        }

        public void Add(Person person)
        {
            this.Persons.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldest = this.Persons.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldest;
        }
    }
}
