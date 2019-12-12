namespace SoftUni.Models
{
    using System;
    using System.Collections.Generic;

    public class Exam
    {
        public Exam()
        {
            StudentsExams = new HashSet<StudentExam>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual ICollection<StudentExam> StudentsExams { get; set; }
    }
}
