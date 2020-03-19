using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KarlaR_300997958.Models
{
    public class Faculty
    {
        [Key]
        [Required(ErrorMessage = "Please enter the Code")]
        public int FacultyCode { get; set; }    /* ID */

        [Required(ErrorMessage = "Please enter the Surname")]
        public string FacultySurname { get; set; }

        [Required(ErrorMessage = "Please enter the Name")]
        public string FacultyName { get; set; }

        [Required(ErrorMessage = "Please enter the e-Mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string FacultyEMail { get; set; }

        public string FacultyCourse { get; set; }
    }
}