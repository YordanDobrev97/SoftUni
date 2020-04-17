using Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace PrintMinionName
{
    public static class PrintMinionsName
    {
        public static void Solution()
        {
            SqlConnection connection = new SqlConnection(Configuration.ConnectionString);

            connection.Open();

            using (connection)
            {
                string selectQuery = @"SELECT Name FROM Minions";
                SqlCommand command = new SqlCommand(selectQuery, connection);

                var minions = command.ExecuteReader();
                List<string> resultMinions = new List<string>();
                while (minions.Read())
                {
                    string name = (string)minions["Name"];
                    resultMinions.Add(name);
                }

                while (resultMinions.Count > 0)
                {
                    var front = resultMinions.FirstOrDefault();
                    var back = resultMinions.LastOrDefault();

                    Console.WriteLine($"Front: {front}");
                    Console.WriteLine($"Back: {back}");

                    resultMinions.Remove(front);
                    resultMinions.Remove(back);
                }
            }
        }
    }
}
