
public class Student
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

    public Student(string firstName, string secondName, int age, string homeTown)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.Age = age;
        this.HomeTown = homeTown;
    }
}

