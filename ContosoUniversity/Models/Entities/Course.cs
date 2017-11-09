using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models.Entities
{
    public partial class Course
    {
        public Course()
        {
            CourseAssignment = new HashSet<CourseAssignment>();
            Enrollment = new HashSet<Enrollment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
