namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

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
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public decimal Salary { get; set; }

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
    }
}
