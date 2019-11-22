using System;

namespace _06.ValidPerson
{
    public class Person
    {
        private string firstName;
        private string secondName;
        private int age;

        public Person(string  firstName, string secondName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }

        public string FirstName
        {
            get => firstName;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name not be empty or null");
                }
                this.firstName = value;
            }
        }

        public string SecondName
        {
            get => this.secondName;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name not be empty or null");
                }
                this.secondName = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(age), "The age should be positive number");
                }
                this.age = value;
            }
        }
    }
}
