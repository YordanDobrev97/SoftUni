namespace SoftUni.Models
{
    public class EmployeeProject
    {
        public EmployeeProject()
        {
            this.Employee = new Employee();
            this.Project = new Project();
        }

        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
