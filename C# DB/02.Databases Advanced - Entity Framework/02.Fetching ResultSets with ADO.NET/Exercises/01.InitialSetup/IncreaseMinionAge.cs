using Connection;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace IncreaseMinionOfAge
{
    public static class IncreaseMinionAge
    {
        public static void Solution()
        {
            int[] ids = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var id in ids)
            {
                using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
                {
                    connection.Open();
                    string updateQuery = @"UPDATE Minions
                                     SET Name = UPPER(LEFT(Name, 1)) +
                                     SUBSTRING(Name, 2, LEN(Name)),
                                     Age += 1
                                     WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }   
            }

            using (SqlConnection connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string selectQuery = @"SELECT Name, Age FROM Minions";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    string name = (string)data["Name"];
                    int age = (int)data["Age"];

                    Console.WriteLine($"{name} {age}");
                }
            }
        }
    }
}
