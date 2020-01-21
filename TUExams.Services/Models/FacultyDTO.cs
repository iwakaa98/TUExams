using System;
using System.Collections.Generic;
using System.Text;
using TUExams.Data.Models;

namespace TUExams.Services.Models
{
    public class FacultyDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
