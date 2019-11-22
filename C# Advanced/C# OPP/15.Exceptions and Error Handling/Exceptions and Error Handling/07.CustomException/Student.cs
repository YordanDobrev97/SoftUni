namespace _07.CustomException
{
    public class Student
    {
        private string name;
        private string email;

        public Student(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value == null)
                {
                    throw new InvalidPersonNameException("The name should have value, not be empty");
                }
                this.name = value;
            }
        }

        public string Email
        {
            get => this.email;
            private set
            {
                if (value == null)
                {
                    throw new InvalidPersonNameException("The email should have value, not be empty");
                }
                this.email = value;
            }
        }
    }
}
