﻿using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models.Entities
{
    public partial class OfficeAssignment
    {
        public int InstructorId { get; set; }
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
