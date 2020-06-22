using System;
using InitialSetup;
using Microsoft.Data.SqlClient;

namespace MinionNames
{
    public class StartUp
    {
        public static void Main()
        {
            var id = int.Parse(Console.ReadLine());

            var connection = new SqlConnection(DefaultSetting.StringConnection);
            connection.Open();

            using (connection)
            {
                var queryNameMinions = @"SELECT Name FROM Villains WHERE Id = @Id";
                var selectNameCommand = new SqlCommand(queryNameMinions, connection);
                selectNameCommand.Parameters.AddWithValue("@Id", id);

                var currentMinion = (string)selectNameCommand.ExecuteScalar();

                if (currentMinion == null)
                {
                    Console.WriteLine($"No villain with ID {id} exists in the database.");
                }
                else
                {
                    var queryNameAndAgeMinions = @"SELECT ROW_NUMBER() OVER 
                                            (ORDER BY m.Name) as RowNum,
                                                 m.Name, 
                                                 m.Age
                                                FROM MinionsVillains AS mv
                                                    JOIN Minions As m ON mv.MinionId = m.Id
                                                WHERE mv.VillainId = @Id
                                                ORDER BY m.Name";
                    var selectNameAndAgeCommand = new SqlCommand(queryNameAndAgeMinions, connection);
                    selectNameAndAgeCommand.Parameters.AddWithValue("@Id", id);

                    var reader = selectNameAndAgeCommand.ExecuteReader();

                    using (reader)
                    {
                        Console.WriteLine($"Villain: {currentMinion}");
                        int countRow = 1;
                        while (reader.Read())
                        {
                            var name = (string)reader["Name"];
                            var age = (int)reader["Age"];

                            Console.WriteLine($"{countRow++}. {name} {age}");
                        }
                    }
                }
            }
        }
    }
}