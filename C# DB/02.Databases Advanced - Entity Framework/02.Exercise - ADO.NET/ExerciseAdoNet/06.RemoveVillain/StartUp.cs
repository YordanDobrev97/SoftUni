using Microsoft.Data.SqlClient;
using System;

namespace RemoveVillain
{
    public class StartUp
    {
        private static string StringConnection = @"Server=.\SQLEXPRESS;Database=MinionsDB;Integrated Security=true;";

        public static void Main()
        {
            var villainId = int.Parse(Console.ReadLine());

            var connection = new SqlConnection(StringConnection);
            connection.Open();

            using (connection)
            {
                using SqlCommand command = new SqlCommand(
                    @"SELECT Name FROM Villains WHERE Id = @villainId", connection);

                command.Parameters.AddWithValue("@villainId", villainId);

                var result = command.ExecuteScalar();

                if (result == null)
                {
                    Console.WriteLine("No such villain was found.");
                }
                else
                {
                    using var deleteMappingTableCommand = new SqlCommand(
                        @"DELETE FROM MinionsVillains 
                            WHERE VillainId = @villainId", connection);

                    deleteMappingTableCommand.Parameters.AddWithValue("@villainId", villainId);
                    deleteMappingTableCommand.ExecuteNonQuery();

                    using var deleteVillainsTableCommand = new SqlCommand(
                        @"DELETE FROM Villains
                            WHERE Id = @villainId", connection);

                    deleteVillainsTableCommand.Parameters.AddWithValue("@villainId", villainId);
                    var minionReleased = deleteVillainsTableCommand.ExecuteNonQuery();

                    Console.WriteLine($"{(string)result} was deleted.");
                    Console.WriteLine($"{minionReleased} minions were released.");
                }
            }
        }
    }
}