using Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace InitialSetup
{
    public static class Initial
    {
        public static void Solution()
        {
            SqlConnection connection = new SqlConnection(ConnectionString.String);

            connection.Open();

            using (connection)
            {
                string createTableCountries =
                    @"CREATE TABLE Countries(
                    Id INT PRIMARY KEY IDENTITY,
                    Name NVARCHAR(50) 
                )";

                string createTableTowns =
                    @"CREATE TABLE Towns(
                    Id INT PRIMARY KEY IDENTITY,
                    Name NVARCHAR(50),
                    CountryCode INT FOREIGN KEY REFERENCES Countries (Id)
                )";

                string createTableMinions =
                    @" CREATE TABLE Minions (
                    Id INT PRIMARY KEY IDENTITY,
                    Name NVARCHAR(50),
                    Age INT NOT NULL,
                    TownId INT FOREIGN KEY REFERENCES Towns (Id)
                )";

                string createTableEvilnessFactors =
                    @"CREATE TABLE EvilnessFactors (
                    Id INT PRIMARY KEY IDENTITY,
                    Name NVARCHAR(50)
                )";

                string createTableVillains =
                    @"CREATE TABLE Villains (
                    Id INT PRIMARY KEY IDENTITY,
                    Name NVARCHAR(50),
                    EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors (Id)
                )";

                string createTableMinionsVillains =
                    @"CREATE TABLE MinionsVillains(
                    MinionId INT FOREIGN KEY REFERENCES Minions(Id),
                    VillainId INT FOREIGN KEY REFERENCES Villains(Id),
                    CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId)
                )";

                List<string> queries = new List<string>();
                queries.Add(createTableCountries);
                queries.Add(createTableTowns);
                queries.Add(createTableMinions);
                queries.Add(createTableEvilnessFactors);
                queries.Add(createTableVillains);
                queries.Add(createTableMinionsVillains);

                foreach (var query in queries)
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
