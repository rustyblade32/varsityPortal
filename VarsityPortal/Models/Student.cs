using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class Student : UserId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public decimal? cgpa { get; set; }
    }
}
