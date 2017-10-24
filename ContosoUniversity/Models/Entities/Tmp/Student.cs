using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models.Entities
{
    public partial class Student
    {
        public Student()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 1)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [StringLength(50, MinimumLength =1 ,ErrorMessage = "First Name cant be more than 50 characters")]
        [Column("FirstName")]
        [Display(Name="First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public String FullName { get
            {
                return FirstMidName + ", " + LastName;
            }
        }

        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
