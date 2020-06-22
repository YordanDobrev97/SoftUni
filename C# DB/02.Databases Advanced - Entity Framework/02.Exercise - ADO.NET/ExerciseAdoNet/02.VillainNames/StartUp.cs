using System;
using Microsoft.Data.SqlClient;
using InitialSetup;

namespace VillainNames
{
    public class StartUp
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection(DefaultSetting.StringConnection);
            connection.Open();

            using (connection)
            {
                var command = @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                                FROM Villains AS v 
                                JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
                            GROUP BY v.Id, v.Name 
                              HAVING COUNT(mv.VillainId) > 3 
                            ORDER BY COUNT(mv.VillainId)";
                SqlCommand sqlCommand = new SqlCommand(command, connection);

                var reader = sqlCommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var name = (string)reader["Name"];
                        var minionsCount = (int)reader["MinionsCount"];

                        Console.WriteLine($"{name} {minionsCount}");
                    }
                }
            }
        }
    }
}