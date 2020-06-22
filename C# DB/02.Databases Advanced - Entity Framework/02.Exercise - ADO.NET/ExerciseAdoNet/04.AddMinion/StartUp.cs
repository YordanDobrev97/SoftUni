using InitialSetup;
using Microsoft.Data.SqlClient;
using System;

namespace AddMinion
{
    public class StartUp
    {
        static SqlConnection connection = new SqlConnection(DefaultSetting.StringConnection);

        public static void Main()
        {
            connection.Open();

            var minionData = Console.ReadLine().Split();
            var villainData = Console.ReadLine().Split();

            var minionName = minionData[1];
            var minionAge = minionData[2];
            var minionTown = minionData[3];

            var villainName = villainData[1];

            using (connection)
            {
                if (!ContainsTown(minionTown))
                {
                    InsertTown(minionTown);
                    Console.WriteLine($"Town {minionTown} was added to the database.");
                }

                if (!ContainsMinion(minionName))
                {
                    InsertMinion(minionName, minionAge, minionTown);
                }

                if (!ContainsVillain(villainName))
                {
                    InsertVillain(villainName);
                    Console.WriteLine($"Villain {villainName} was added to the database.");
                }

                //contains minion and villain
                if (GetIdMinion(minionName) > 0 && GetIdVillain(villainName) > 0)
                {
                    var idMinion = GetIdMinion(minionName);
                    var idVillain = GetIdVillain(villainName);

                    var insertMappingTableCommand = new SqlCommand(
                        @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)",
                        connection);

                    insertMappingTableCommand.Parameters.AddWithValue("@minionId", idMinion);
                    insertMappingTableCommand.Parameters.AddWithValue("@villainId", idVillain);

                    insertMappingTableCommand.ExecuteNonQuery();

                    Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
                }
            }
        }

        private static int GetIdVillain(string villainName)
        {
            var villainCommand = new SqlCommand(
                @"SELECT Id FROM Villains WHERE Name = @name", connection);

            villainCommand.Parameters.AddWithValue("@name", villainName);
            var result = villainCommand.ExecuteScalar();

            return result == null ? 0 : (int)result;
        }

        private static void InsertVillain(string villainName)
        {
            int defaultEvilnessFactors = 4;
            var insertCommand = new SqlCommand(
                @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, @evilFactory)", 
                connection);

            insertCommand.Parameters.AddWithValue("@villainName", villainName);
            insertCommand.Parameters.AddWithValue("@evilFactory", defaultEvilnessFactors);

            insertCommand.ExecuteNonQuery();
        }

        private static bool ContainsVillain(string villainName)
        {
            return GetIdVillain(villainName) > 0;
        }

        private static bool ContainsTown(string minionTown)
        {
            return GetIdTown(minionTown) > 0;
        }

        private static void InsertTown(string town)
        {
            var insertTownCommand = new SqlCommand(
                @"INSERT INTO Towns (Name) VALUES (@townName)", connection);

            insertTownCommand.Parameters.AddWithValue("@townName", town);
            insertTownCommand.ExecuteNonQuery();
        }

        private static void InsertMinion(string minionName, string minionAge, string minionTown)
        {
            var townId = GetIdTown(minionTown);

            var insertMinionCommand = new SqlCommand(
                @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)", 
                connection);

            insertMinionCommand.Parameters.AddWithValue("@name", minionName);
            insertMinionCommand.Parameters.AddWithValue("@age", minionAge);
            insertMinionCommand.Parameters.AddWithValue("@townId", townId);

            insertMinionCommand.ExecuteNonQuery();
        }

        private static bool ContainsMinion(string minion)
        {
            return GetIdMinion(minion) > 0;
        }

        private static int GetIdMinion(string minion)
        {
            var containsMinionCommand = new SqlCommand(
                    @"SELECT Id FROM Minions WHERE Name = @Name", connection);

            containsMinionCommand.Parameters.AddWithValue("@name", minion);

            var result = containsMinionCommand.ExecuteScalar();
            return result == null ? 0 : (int)result;
        }

        private static int GetIdTown(string town)
        {
            var containsTownCommand = new SqlCommand(
                @"SELECT Id FROM Towns WHERE Name = @townName", connection);

            containsTownCommand.Parameters.AddWithValue("@townName", town);

            var result = containsTownCommand.ExecuteScalar();
            return result == null ? 0 : (int)result;
        }
    }
}