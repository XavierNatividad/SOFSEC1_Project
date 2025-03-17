using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFSEC1_Project
{
    class GradeModel
    {
        public int gradeId { get; set; }
        public int userId { get; set; }
        public int courseCode { get; set; }
        public string courseName { get; set; }
        public int termNumber { get; set; }
        public int units { get; set; }
        public int grade { get; set; }
    }
}
