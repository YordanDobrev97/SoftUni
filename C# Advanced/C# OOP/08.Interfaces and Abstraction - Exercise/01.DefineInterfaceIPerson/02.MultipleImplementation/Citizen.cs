namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string id;
        private string name;
        private int age;
        private string birthday;

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthday;
        }


        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }
        public int Age
        {
            get => this.age;
            private set => this.age = value;
        }

        public string Id
        {
            get => this.id;
            private set => this.id = value;
        }

        public string Birthdate
        {
            get => this.birthday;
            private set => this.birthday = value;
        }
    }
}
