using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models.Entities
{
    public partial class Department
    {
        public Department()
        {
            Course = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}
