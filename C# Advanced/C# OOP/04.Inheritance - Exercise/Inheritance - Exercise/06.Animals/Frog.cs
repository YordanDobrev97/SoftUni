namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("Ribbit");
        }
    }
}
