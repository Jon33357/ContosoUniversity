using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models.Entities
{
    public partial class CourseAssignment
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
