using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Department Name")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Sections> Sections { get; set; }
        [Required]
        public int Credits { get; set; }
    }
}
