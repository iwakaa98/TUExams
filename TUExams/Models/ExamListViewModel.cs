using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TUExams.Models
{
    public class ExamListViewModel
    {
        public string Session { get; set; }
        public int Year { get; set; }
        public int NextYear { get; set; }
        public string FacultyName { get; set; }
        public int CourseNumber { get; set; }
        public ICollection<ExamViewModel> Exams { get; set; }
    }
}
