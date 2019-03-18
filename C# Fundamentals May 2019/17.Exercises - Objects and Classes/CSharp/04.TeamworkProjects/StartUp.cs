using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    class User
    {
        public string Name { get; private set; }
        public Team Team { get; set; }

        public User(string name, Team team)
        {
            this.Name = name;
            this.Team = team;
        }
    }

    class Team
    {
        public string Name { get; private set; }

        public Team(string name)
        {
            this.Name = name;
        }
    }

    public static void Main()
    {
        int countTeam = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        List<User> users = new List<User>();

        while (input != "end of assignment")
        {
            string[] inputParams = input.Split(new[] { "-", "->" }, 
                StringSplitOptions.RemoveEmptyEntries);

            string user = inputParams[0];
            string team = inputParams[1];

            Team currentTeam = new Team(team);
            User currentUser = new User(user, currentTeam);

            if (isExistUser(currentUser, users) && isExistTeam(users, currentTeam))
            {
                PrintMessage($"Member {currentUser.Name} cannot join team {currentTeam.Name}");
            }
            else if (isExistTeam(users, currentTeam))
            {
                PrintMessage($"Team {currentTeam.Name} was already created!");
            }
            else if (isExistUser(currentUser, users) && !(isExistTeam(users, currentTeam)))
            {
                PrintMessage($"Team {currentTeam.Name} does not exist!");
            }
            else
            {
                if (!isExistUser(currentUser, users))
                {
                    users.Add(currentUser);
                }
            }

            input = Console.ReadLine();
        }
    }

    private static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    private static bool isExistUser(User currentUser, List<User> users)
    {
        return users.Exists(x => x.Name == currentUser.Name);
    }

    private static bool isExistTeam(List<User> users, Team currentTeam)
    {
       return users.Exists(x => x.Team.Name == currentTeam.Name);
    }
}

