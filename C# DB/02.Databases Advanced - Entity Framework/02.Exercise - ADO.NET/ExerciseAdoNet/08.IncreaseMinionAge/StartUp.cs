﻿using Microsoft.Data.SqlClient;
using System;
using System.Linq;

namespace IncreaseMinionAge
{
    public class StartUp
    {
        private static string StringConnection = @"Server=.\SQLEXPRESS;Database=MinionsDB;Integrated Security=true;";

        public static void Main()
        {
            var ids = Console.ReadLine().Split().Select(int.Parse).ToList();

            var connection = new SqlConnection(StringConnection);
            connection.Open();

            using (connection)
            {
                foreach (var id in ids)
                {
                    using var command = new SqlCommand(
                                    @"UPDATE Minions
                                    SET Name = UPPER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
                                    WHERE Id = @Id", 
                                  connection);

                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }

                using var getCommand = new SqlCommand(
                    "SELECT Name, Age FROM Minions", connection);

                var reader = getCommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var name = (string)reader["Name"];
                        var age = (int)reader["Age"];

                        Console.WriteLine($"{name} {age}");
                    }
                }
            }
        }
    }
}