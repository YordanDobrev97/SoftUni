using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [Test]
        public void Test_Add_Max_Person_Data()
        {
            var persons = new ExtendedDatabase.Person[]
            {
                new ExtendedDatabase.Person(1,"Joni"),
                new ExtendedDatabase.Person(2,"Moni"),
                new ExtendedDatabase.Person(3,"Toni"),
                new ExtendedDatabase.Person(4,"Roni"),
                new ExtendedDatabase.Person(5,"Kiro"),
                new ExtendedDatabase.Person(6,"Miro"),
                new ExtendedDatabase.Person(7,"Ivo"),
                new ExtendedDatabase.Person(8,"Dido"),
                new ExtendedDatabase.Person(9,"Ivan"),
                new ExtendedDatabase.Person(10,"Stamat"),
                new ExtendedDatabase.Person(11,"Mariq"),
                new ExtendedDatabase.Person(12,"Petq"),
                new ExtendedDatabase.Person(13,"Ivana"),
                new ExtendedDatabase.Person(14,"Svetla"),
                new ExtendedDatabase.Person(15,"Elena"),
                new ExtendedDatabase.Person(16,"Viki"),
            };
            var database = new 
                ExtendedDatabase.ExtendedDatabase(persons);

            Assert.AreEqual(database.Count, 16);
        }

        [Test]
        public void Add_Person_Data()
        {
            var database = new
                ExtendedDatabase.ExtendedDatabase();

            database.Add(new ExtendedDatabase.Person(1, "Niki"));
            Assert.AreEqual(database.Count, 1);
        }

        [Test]
        public void Try_Add_With_Max_Capacity_Data()
        {
            var database = new
                ExtendedDatabase.ExtendedDatabase();

            string[] names = new string[]
            {
                "Ivi", "Mimi", "Vili", "Viki", "Petq", "Galq",
                "Ivo", "Kiro", "Dancho", "Nik", "Nikolay", "Deni",
                "Mariq", "Denislav", "Miro", "Stivi"
            };

            for (int i = 1; i <=16; i++)
            {
                database.Add(new ExtendedDatabase.Person(i, names[i - 1]));
            }
            
            Assert.Throws<InvalidOperationException>(() => 
            database.Add(new ExtendedDatabase.Person(16, "Joni Test")));
        }

        [Test]
        public void Add_Exist_Person_Name()
        {
            var database = new
                ExtendedDatabase.ExtendedDatabase();

            database.Add(new ExtendedDatabase.Person(1, "Ivo"));
            Assert.Throws<InvalidOperationException>(() => 
            database.Add(new ExtendedDatabase.Person(2, "Ivo")));
        }

        [Test]
        public void Add_Exist_Person_Id()
        {
            var database = new
                ExtendedDatabase.ExtendedDatabase();

            database.Add(new ExtendedDatabase.Person(1, "Ivo"));
            Assert.Throws<InvalidOperationException>(() =>
            database.Add(new ExtendedDatabase.Person(1, "Kiro")));
        }

        [Test]
        public void Remove_Person_Success()
        {
            var database = new
               ExtendedDatabase.ExtendedDatabase();

            database.Add(new ExtendedDatabase.Person(1, "Pesho"));
            database.Remove();

            Assert.AreEqual(database.Count, 0);
        }

        [Test]
        public void Try_Remove_With_Empty_Data()
        {
            var database = new
               ExtendedDatabase.ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Find_By_User_Name_With_Null_Name()
        {
            var database = new
               ExtendedDatabase.ExtendedDatabase();

            database.Add(new ExtendedDatabase.Person(1, "Iva"));
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));
        }

        [Test]
        public void Find_By_User_Name_With_Not_Exist_Person()
        {
            var database = new
              ExtendedDatabase.ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Ivo"));
        }

        [Test]
        public void Find_By_User_Name_Success()
        {
            var database = new
              ExtendedDatabase.ExtendedDatabase();

            var ivo = new ExtendedDatabase.Person(1, "Ivo");
            database.Add(ivo);
            var person = database.FindByUsername("Ivo");
            Assert.AreEqual(person, ivo);
        }

        [Test]
        public void Find_By_Id_With_Negative_Id()
        {
            var database = new
              ExtendedDatabase.ExtendedDatabase();

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-3));
        }

        [Test]
        public void Find_By_Id_Wit_Not_Exist_Person_Id()
        {
            var database = new
             ExtendedDatabase.ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => database.FindById(3));
        }

        [Test]
        public void Find_By_Id_Success()
        {
            var db = new
             ExtendedDatabase.ExtendedDatabase();

            var ivo = new ExtendedDatabase.Person(1, "Ivo");
            db.Add(new ExtendedDatabase.Person(1, "Ivo"));

            Assert.Throws<InvalidOperationException>(() => 
            db.FindById(3));
        }
    }
}