using InitialSetup;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace ChangeTownNamesCasing
{
    public class StartUp
    {
        public static void Main()
        {
            string countryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection(DefaultSetting.StringConnection);
            connection.Open();

            using (connection)
            {
                SqlCommand updateCommand = new SqlCommand(
                                            @"UPDATE Towns
                                                SET Name = UPPER(Name)
                                            WHERE CountryCode = 
                                                (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)", connection);

                updateCommand.Parameters.AddWithValue("@countryName", countryName);

                int affectedRows = updateCommand.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No town names were affected.");
                }
                else
                {
                    SqlCommand getCountryCommand = new SqlCommand(
                                           @"SELECT t.Name 
                                                FROM Towns as t
                                                JOIN Countries AS c ON c.Id = t.CountryCode
                                                WHERE c.Name = @countryName",
                                           connection);

                    getCountryCommand.Parameters.AddWithValue("@countryName", countryName);

                    var reader = getCountryCommand.ExecuteReader();

                    List<string> towns = new List<string>();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            var townName = (string)reader[0];
                            towns.Add(townName);
                        }
                    }

                    Console.WriteLine($"{(int)affectedRows} town names were affected. ");
                    Console.WriteLine($"[{string.Join(", ", towns)}]");
                }
            }
        }
    }
}