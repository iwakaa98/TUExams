using System;
using System.Collections.Generic;
using System.Text;

namespace TUExams.Data.Models
{
    public class Faculty
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<Exam> Exams { get; set; }    
    }
}
