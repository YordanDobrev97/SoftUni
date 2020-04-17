using Connection;
using System;
using System.Data.SqlClient;

namespace AddMinions
{
    public static class AddMinion
    {
        private static int minionId;
        private static int villainId;

        public static void Solution()
        {
            string[] minionInput = Console.ReadLine().Split();
            string name = minionInput[1];
            int age = int.Parse(minionInput[2]);
            string town = minionInput[3];

            string[] vilianInput = Console.ReadLine().Split();
            string vilianName = vilianInput[1];

            string viliainsQuery = @"SELECT Id FROM Villains
                                    WHERE Name = @Name";

            string townQuery = @"SELECT Towns.Id FROM Minions
                                JOIN Towns ON Minions.TownId = Towns.Id
                                WHERE Towns.Name = @town";

            SqlConnection connection = new SqlConnection(Configuration.ConnectionString);
            connection.Open();

            using (connection)
            {
                AddVilianIfNotExist(vilianName, viliainsQuery, connection);
                AddMinonIfNotExist(name, age, town, townQuery, connection);

                string minionVilianQuery = @"INSERT INTO MinionsVillains (MinionId, VillainId) 
                                            VALUES (@minionId, @villainId)";

                SqlCommand command = new SqlCommand(minionVilianQuery, connection);
                command.Parameters.AddWithValue("@minionId", minionId);
                command.Parameters.AddWithValue("@villainId", villainId);

                Console.WriteLine($"Successfully added {name} to be minion of {vilianName}.");
            }
        }

        /// <summary>
        /// Check name, age, and town if not exist him adding in database 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="town"></param>
        /// <param name="townQuery"></param>
        /// <param name="connection"></param>
        private static void AddMinonIfNotExist(string name, int age, string town, string townQuery, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(townQuery, connection);
            command.Parameters.AddWithValue("@town", town);

            object result = command.ExecuteScalar();
            if (result == null)
            {
                string insertQuery = @"INSERT INTO Towns (Name) VALUES (@town)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@town", town);

                insertCmd.ExecuteScalar();
                Console.WriteLine($"Town {town} was added to the database.");
            }
            else
            {
                minionId = (int)result;
            }
        }

        /// <summary>
        /// Check vilianName and if not exist him adding in database 
        /// </summary>
        /// <param name="vilianName"></param>
        /// <param name="viliainsQuery"></param>
        /// <param name="connection"></param>
        private static void AddVilianIfNotExist(string vilianName, string viliainsQuery, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(viliainsQuery, connection);
            command.Parameters.AddWithValue("@Name", vilianName);

            object result = command.ExecuteScalar();
            if (result == null)
            {
                string insertQuery = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@Name, 4)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@Name", vilianName);
                insertCommand.ExecuteScalar();

                Console.WriteLine($"Villain {vilianName} was added to the database.");
            }
            else
            {
                villainId = (int)result;
            }
        }
    }
}
