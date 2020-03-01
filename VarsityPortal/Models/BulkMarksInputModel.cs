using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class BulkMarksInputModel
    {

        public string ExamName { get; set; }
        public int OutOf { get; set; }
        public List<decimal> Marks { get; set; } = new List<decimal>();
    }
}
