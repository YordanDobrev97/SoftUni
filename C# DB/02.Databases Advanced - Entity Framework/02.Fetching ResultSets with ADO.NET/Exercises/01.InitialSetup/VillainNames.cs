using Connection;
using InitialSetup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace VillainName
{
    public static class VillainNames
    {
        public static void Solution()
        {
            string query = @"SELECT[Name], 
                           COUNT(mv.MinionId) AS[MinionsCount]
                           FROM Villains AS v
                           JOIN MinionsVillains AS mv ON v.Id = mv.VillainId
                           GROUP BY[Name]
                           HAVING COUNT(mv.MinionId) > 3
                           ORDER BY COUNT(mv.MinionId) DESC";

            SqlConnection connection = new SqlConnection(ConnectionString.String);

            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    string name = (string)data["Name"];
                    int countMinions = (int)data["MinionsCount"];

                    Console.WriteLine($"{name} - {countMinions}");
                }
            }
        }
    }
}
