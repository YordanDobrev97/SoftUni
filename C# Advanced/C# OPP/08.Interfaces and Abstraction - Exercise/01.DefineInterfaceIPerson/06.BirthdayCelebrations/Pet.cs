using System;

namespace BirthdayCelebrations
{
    public class Pet : IIdentifiable, IBirthdable
    {
        private const string DefaultId = "Pet";
        private string id;

        public Pet(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Id = DefaultId;
        }

        public string Name { get; set; }

        public DateTime Birthday { get; private set; }

        public string Id
        {
            get => this.id;
            private set => this.id = value;
        }
    }
}
