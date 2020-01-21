using System;
using System.Collections.Generic;
using System.Text;

namespace TUExams.Data.Models
{
    public class Course
    {
        
        public string Id { get; set; }
        public int Number { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
