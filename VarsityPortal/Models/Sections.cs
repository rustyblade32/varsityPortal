using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class Sections
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public int Number { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
