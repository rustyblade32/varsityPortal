using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class UserId
    {
        public int Id { get; set; }

        [Display(Name = "Admission Year")]
        public int Year { get; set; }
        public int Semester { get; set; }

        [Display(Name = "Dapartment")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
