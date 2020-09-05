using System;

namespace PersonsInfo
{
    public class Person
    {
        private const string messageName = "{0} cannot contain fewer than 3 symbols!";

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (!Least3Symbols(value))
                {
                    string error = string.Format(messageName, "First name");
                    throw new ArgumentException(error);
                }
                this.firstName = value;
            }
        }       

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (!Least3Symbols(value))
                {
                    string error = string.Format(messageName, "Last name");
                    throw new ArgumentException(error);
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                //increasing double salary
                this.Salary += this.Salary * percentage / 200;
            } 
            else
            {
                this.Salary += this.Salary * percentage / 100;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {Salary:F2} leva.";
        }

        private bool Least3Symbols(string value)
        {
            return value.Length >= 3;
        }
    }
}
