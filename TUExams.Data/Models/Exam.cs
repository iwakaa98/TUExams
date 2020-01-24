using System;
using System.Collections.Generic;
using System.Text;

namespace TUExams.Data.Models
{
    public class Exam
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int ExamHall { get; set; }
        public Course Course { get; set; }
        public string CourseId { get; set; }
        public Faculty Faculty { get; set; }
        public string FacultyId { get; set; }
    }
}
