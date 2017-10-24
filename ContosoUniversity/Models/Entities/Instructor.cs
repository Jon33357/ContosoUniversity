using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models.Entities
{
    public partial class Instructor
    {
        public Instructor()
        {
            CourseAssignment = new HashSet<CourseAssignment>();
            Department = new HashSet<Department>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}
