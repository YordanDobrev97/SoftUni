namespace SoftUni.Models
{
    using System;
    using System.Collections.Generic;

    public class StudentExam
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public decimal Grade { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Student Student { get; set; }
    }
}
