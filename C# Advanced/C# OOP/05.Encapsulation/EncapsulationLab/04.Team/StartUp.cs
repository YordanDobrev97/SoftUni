using System;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            Person pesho = new Person("Pesho", "Petrov", 23, 40000);
            Person gosho = new Person("Gosho", "Geogriev", 53, 100000);

            Team team = new Team("The dogs");
            team.AddPlayer(pesho);
            team.AddPlayer(gosho);

            Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.ReserveTeam.Count);
        }
    }
}
