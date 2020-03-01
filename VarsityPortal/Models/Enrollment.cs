using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityPortal.Models
{
    public class Enrollment
    {
        public int SectionId { get; set; }
        public Sections Section { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public List<Mark> marks { get; set; }
        public bool IsFinished { get; set; }
        public decimal gpa { get; set; }


        public decimal CalculateGpa()
        {
            decimal totalMark = 0;
            decimal gpa = 0;
            if (this.IsFinished)
            {
                foreach(var mark in this.marks)
                {
                    totalMark += mark.Score;
                }
                if(totalMark >= 90)
                {
                    gpa = 4.0m;
                }
                else if(totalMark >= 87)
                {
                    gpa = 3.7m;
                }
                else if(totalMark >= 83)
                {
                    gpa = 3.3m;
                }
                else if(totalMark >= 80)
                {
                    gpa = 3.0m;
                }
                else if(totalMark >= 77)
                {
                    gpa = 2.7m;
                }
                else if(totalMark >= 73)
                {
                    gpa = 2.3m;
                }
                else if(totalMark >= 70)
                {
                    gpa = 2.0m;
                }
                else if(totalMark >= 67) {
                    gpa = 1.7m;
                }
                else if(totalMark >= 63)
                {
                    gpa = 1.3m;
                }
                else if(totalMark >= 60)
                {
                    gpa = 1.0m;
                }
                else
                {
                    gpa = 0.0m;
                }
                return gpa;
            }
            return 0.0m;
        }
    }
}
