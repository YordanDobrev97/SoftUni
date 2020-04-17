using Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MinionName
{
    public static class MinionNames
    {
        public static void Solution()
        {
            int idMinion = int.Parse(Console.ReadLine());

            string minionQuery = @"SELECT ROW_NUMBER() OVER(ORDER BY [Name]) AS RowNumber, 
                           m.[Name] AS MinionName, 
                           m.Age AS MinionAge
                           FROM MinionsVillains AS mv
                           JOIN Minions AS m ON m.Id = mv.MinionId
                           WHERE mv.VillainId = @Id
                           ORDER BY m.[Name]";

            string vilianQuery = @"SELECT [Name] FROM Villains WHERE Id = @Id";

            SqlConnection connection = new SqlConnection(Configuration.ConnectionString);

            connection.Open();
            using (connection)
            {
                SqlCommand vilianCmd = new SqlCommand(vilianQuery, connection);
                vilianCmd.Parameters.AddWithValue("@Id", idMinion);

                string vilianName = (string)vilianCmd.ExecuteScalar();
                Console.WriteLine($"Villain: {vilianName}");

                SqlCommand minionsQuery = new SqlCommand(minionQuery, connection);

                minionsQuery.Parameters.AddWithValue("@Id", idMinion);

                int counter = 1;
                using (minionsQuery)
                {
                    var executeReader = minionsQuery.ExecuteReader();

                    using (executeReader)
                    {
                        while (executeReader.Read())
                        {
                            string minionName = (string)executeReader["MinionName"];

                            if (executeReader.HasRows)
                            {
                                int minionAge = (int)executeReader["MinionAge"];
                                Console.WriteLine($"{counter++} {minionName} {minionAge}");
                            }
                            else
                            {
                                Console.WriteLine("(no minions)");
                            }
                        }
                    }
                }
            }

        }
    }
}
