using Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ChangeTownNamesCasing
{
    public static class CasingName
    {
        public static void Solution()
        {
            string country = Console.ReadLine();

            SqlConnection connection = new SqlConnection(ConnectionString.String);
            connection.Open();

            using (connection)
            {
                string selectQuery = @"SELECT t.Name AS [TownName]
                                       FROM Towns as t
                                       JOIN Countries AS c ON c.Id = t.CountryCode
                                       WHERE c.Name = @country";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@country", country);

                var targetCountry = command.ExecuteScalar();
                
                if (targetCountry != null)
                {
                    string updateQuery = @"UPDATE Towns
                                      SET Name = UPPER(Name)
                                      WHERE CountryCode = (SELECT c.Id 
                                      FROM Countries AS c 
                                      WHERE c.Name = @countryName)";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@countryName", country);

                    int affectedRows = updateCmd.ExecuteNonQuery();
                    Console.WriteLine($"{affectedRows} town names were affected. ");

                    var towns = command.ExecuteReader();

                    List<string> allTowns = new List<string>();
                    while (towns.Read())
                    {
                        string currentTown = (string)towns["TownName"];
                        allTowns.Add(currentTown);
                    }

                    Console.WriteLine($"[{string.Join(", ", allTowns)}]");
                }
                else
                {
                    Console.WriteLine("No town names were affected.");
                }
            }
        }
    }
}
