using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Add_Data()
        {
            int[] data = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            Database database = new Database(data);
            database.Add(16);

            Assert.AreEqual(database.Count, 16);
        }

        [Test]
        public void Add_Element_With_Max_Capacity_Data_Throw_Invalid_Operation_Exception()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Database database = new Database(data);

            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [Test]
        public void Remove_Last_Element_From_Data()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Database database = new Database(data);

            database.Remove();
            Assert.AreEqual(database.Count, 15);
        }

        [Test]
        public void Remove_Element_With_Empty_Data_Count()
        {
            int[] data = new int[] { };
            Database database = new Database(data);

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Fetch_Data()
        {
            int[] data = new int[] {1,2,3,4,5,6,7,8,9,10};
            Database database = new Database(data);

            int[] fetchData = database.Fetch();
            Assert.AreEqual(fetchData.Length, 10);
        }
    }
}