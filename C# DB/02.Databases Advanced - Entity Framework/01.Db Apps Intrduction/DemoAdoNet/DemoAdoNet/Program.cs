namespace DemoAdoNet
{
    using System;
    using System.Data.SqlClient;

    class Program
    {
        private const string ConnectionString = 
            @"Server=.\SQLEXPRESS; Database=SoftUni;Integrated Security=true";

        static void Main()
        {
            string townName = Console.ReadLine();

            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            using (connection)
            {
                SqlCommand selectTowns = new 
                    SqlCommand("SELECT * FROM Towns", connection);

                var reader = selectTowns.ExecuteReader();

                bool found = false;
                using (reader)
                {
                    while (reader.Read())
                    {
                        var town = (string) reader["Name"];

                        if (town == townName)
                        {
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO Towns (Name) VALUES (@param)", connection);

                    insertCommand.Parameters.AddWithValue("@param", townName);
                    insertCommand.ExecuteNonQuery();

                    Console.WriteLine($"{townName} added!");
                }
            }
        }
    }
}