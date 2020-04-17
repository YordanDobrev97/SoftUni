using Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _06.RemoveVillain
{
    public static class RemoveVillain
    {
        public static void Solution()
        {
            int villainId = int.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection(Configuration.ConnectionString);

            connection.Open();
            using (connection)
            {
                string selectQuery = @"SELECT Name FROM Villains WHERE Id = @villainId";
                string deleteMinionVillainQuery = @"DELETE FROM MinionsVillains WHERE VillainId = @villainId";
                string deleteVillainsQuery = @"DELETE FROM Villains WHERE Id = @villainId";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@villainId", villainId);

                string name = (string)command.ExecuteScalar();
                if (name == null)
                {
                    Console.WriteLine("No such villain was found.");
                }
                else
                {
                    SqlCommand deleteMinionVillainsCmd = new SqlCommand(deleteMinionVillainQuery, connection);
                    deleteMinionVillainsCmd.Parameters.AddWithValue("@villainId", villainId);

                    int deletedMinionVillains = deleteMinionVillainsCmd.ExecuteNonQuery();

                    SqlCommand deleteVillainsCmd = new SqlCommand(deleteVillainsQuery, connection);
                    deleteVillainsCmd.Parameters.AddWithValue("@villainId", villainId);

                    deleteVillainsCmd.ExecuteNonQuery();
                    Console.WriteLine($"{name} was deleted.");
                    Console.WriteLine($"{deletedMinionVillains} minions were released.");
                }
            }
        }
    }
}
