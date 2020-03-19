using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public class Course
    {
        [Key]
        [Required(ErrorMessage = "Please enter the Code")]
        public string CourseCode { get; set; }

        [Required(ErrorMessage = "Please enter the Course Name")]
        public string CourseName { get; set; }

        public string CourseFaculty { get; set; }

        [Required(ErrorMessage = "Please enter with a Descripton")]
        public string CourseDesc { get; set; }
    }
}