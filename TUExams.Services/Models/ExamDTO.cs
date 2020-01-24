using System;
using System.Collections.Generic;
using System.Text;

namespace TUExams.Services.Models
{
    public class ExamDTO
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int ExamHall { get; set; }
    }
}
