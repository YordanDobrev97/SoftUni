namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        private string id;
        private string model;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Id
        {
            get => this.id;
            private set => this.id = value;
        }

        public string Model
        {
            get => this.model;
            private set => this.model = value;
        }
    }
}
