namespace SoftUni.Models
{
    public class StudentTeacher
    {
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
