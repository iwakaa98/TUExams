using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TUExams.Models
{
    public class ExamViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public string Minutes { get; set; }
        public int Duration { get; set; }
        public int ExamHall { get; set; }
    }
}
