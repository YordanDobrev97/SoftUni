using System;

namespace OPP
{
    public class StartUp
    {
        static void Main()
        {
            Family simpson = new Family();
            simpson.Name = "Simpson";

            simpson.Mother.Name = "Marge";
            simpson.Father.Name = "Homer";

            simpson.Children.Add(new Child("Lisa"));
            simpson.Children.Add(new Child("Bart"));

            //-----------------------------------------

            School school = new School("Hristo Botev");
            Student pesho = new Student("Pesho");
            Teacher maria = new Teacher("Maria");
            school.Student = pesho;
            school.Teacher = maria;
        }
    }
}
