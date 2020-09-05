using System;

namespace Person
{
    public class Person
    {
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("People should not be able to have a negative age");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
