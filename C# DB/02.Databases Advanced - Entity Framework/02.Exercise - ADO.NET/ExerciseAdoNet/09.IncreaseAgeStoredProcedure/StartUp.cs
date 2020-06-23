using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace IncreaseAgeStoredProcedure
{
    public class StartUp
    {
        private static string StringConnection = @"Server=.\SQLEXPRESS;Database=MinionsDB;Integrated Security=true;";

        public static void Main()
        {
            int minionId = int.Parse(Console.ReadLine());

            var connection = new SqlConnection(StringConnection);
            connection.Open();

            using (connection)
            {
                using var executeStoredProcedure = new SqlCommand(@"usp_GetOlder", connection);

                executeStoredProcedure.CommandType = CommandType.StoredProcedure;
                executeStoredProcedure.Parameters.AddWithValue("@id", minionId);

                executeStoredProcedure.ExecuteNonQuery();

                using var selectCommand = new SqlCommand(
                    @"SELECT Name, Age FROM Minions WHERE Id = @Id", connection);

                selectCommand.Parameters.AddWithValue("@Id", minionId);
                var reader = selectCommand.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var name = (string)reader["Name"];
                        var age = (int)reader["Age"];

                        Console.WriteLine($"{name} - {age} years old");
                    }
                }
            }
        }
    }
}