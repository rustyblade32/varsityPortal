using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string ExamName { get; set; }

  
        public decimal Score { get; set; }

        public decimal OutOf { get; set; }

        public int EnrollmentStudentId { get; set; }
        public int EnrollmentSectionId { get; set; }
        public Enrollment Enrollment { get; set; }
    }
}
