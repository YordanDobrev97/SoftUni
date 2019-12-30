namespace SoftUni.Models
{
    using System.Collections.Generic;

    public class Teacher
    {
        public Teacher()
        {
            StudentsTeachers = new HashSet<StudentTeacher>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual ICollection<StudentTeacher> StudentsTeachers { get; set; }
    }
}
