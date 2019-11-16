namespace Ferrari
{
    public class Ferrari : ICar
    {
        private const string DefaultModel = "488-Spider";
        private string model;
        private string driverName;

        public Ferrari(string driverName)
        {
            this.Model = DefaultModel;
            this.DriverName = driverName;
        }

        public string Model
        {
            get => this.model;
            private set => this.model = value;
        }
        public string DriverName
        {
            get => this.driverName;
            set => this.driverName = value;
        }

        public string Brake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brake()}/{this.Gas()}/{this.DriverName}";
        }
    }
}
