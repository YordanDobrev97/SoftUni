using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    class User
    {
        public string Name { get; private set; }

        public User(string name)
        {
            this.Name = name;
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
        
        List<User> users = new List<User>();
        List<Team> teams = new List<Team>();

        for (int i = 0; i < countTeam; i++)
        {
            string[] team = Console.ReadLine()
                .Split('-');
            string nameUser = team[0];
            string nameTeam = team[1];

            Team currentTeam = new Team(nameTeam);
            User currentUser = new User(nameUser);

            if (!users.Contains(currentUser))
            {
                users.Add(currentUser);
            }

            if (!teams.Contains(currentTeam))
            {
                teams.Add(currentTeam);
                Console.WriteLine($"Team {nameTeam} has been created by {nameUser}!");
            }
        }

        string line = Console.ReadLine();

        while (line != "end of assignment")
        {
            string[] items = line.Split(new[] { '-', '>' },
                StringSplitOptions.RemoveEmptyEntries);


            string nameUser = items[0];
            string team = items[1];

            Team newTeam = new Team(team);
            User newUser = new User(nameUser);

            if (ExistUserCheck(users, newUser) && ExistTeamCheck(teams, newTeam))
            {
                Console.WriteLine($"Member {nameUser} cannot join team {team} is the best!");
            }
            else if (ExistTeamCheck(teams, newTeam))
            {
                Console.WriteLine($"Team {team} was already created!");
            }
            else
            {
                if (ExistUserCheck(users, newUser))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else
                {
                    teams.Add(newTeam);
                }
            }
            
            if (ExistUserCheck(users, newUser))
            {
                Console.WriteLine($"{nameUser} cannot create another team!");

            }

            line = Console.ReadLine();
        }

        foreach (var team in teams)
        {
            Console.WriteLine($"-{team.Name}");

            foreach (var user in users)
            {
                Console.WriteLine($"--{user.Name}");
            }
        }
    }

    private static bool ExistUserCheck(List<User> users, User newUser)
    {
        return users.Contains(newUser);
    }

    private static bool ExistTeamCheck(List<Team> teams, Team newTeam)
    {
        bool contains = false;

        foreach (var item in teams)
        {
            string name = item.Name;
            if (name == newTeam.Name)
            {
                contains = true;
                break;
            }
        }

        return contains;
    }
}

