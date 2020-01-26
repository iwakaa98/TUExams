using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TUExams.Data;
using TUExams.Data.Models;
using TUExams.Services.Mappers.Contracts;
using TUExams.Services.Models;
using TUExams.Services.Services.Contracts;

namespace TUExams.Services.Services
{
    public class ExamService : IExamService
    {
        private readonly TUExamContext _context;
        private readonly IExamDTOMapper _examDTOMapper;

        public ExamService(TUExamContext context, IExamDTOMapper examDTOMapper)
        {
            _context = context;
            _examDTOMapper = examDTOMapper;
        }

        public async Task CreateAsync(string facultyname, DateTime day, int hall, int duration, int coursenumber, string starttime, string examname)
        {

            var hours = Int32.Parse(starttime.Split(":")[0]);
            var minutes = Int32.Parse(starttime.Split(":")[1]);
            var date = new DateTime(day.Year, day.Month, day.Day, hours, minutes, 0);
            var course = await _context.Courses.FirstOrDefaultAsync(x => x.Number == coursenumber);
            var faculty = await _context.Faculties.FirstOrDefaultAsync(x => x.Name == facultyname);
            var exam = new Exam
            {
                CourseId = course.Id,
                FacultyId = faculty.Id,
                Title = examname,
                ExamHall = hall,
                Date = date,
                Duration = duration,
            };
            await _context.Exams.AddAsync(exam);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<ExamDTO>> GetExamsAsync(string faculty, int course)
        {

            var exams = await _context.Exams.Where(x => x.Faculty.Name == faculty && x.Course.Number == course).ToListAsync();
            return _examDTOMapper.MapFrom(exams);
        }

        public async Task<bool> IsValidDayAndHallAsync(int hall, DateTime day, string starttime)
        {
            var hours = Int32.Parse(starttime.Split(":")[0]);
            var minutes = Int32.Parse(starttime.Split(":")[1]);

            var boolean = await _context.Exams.AnyAsync(x => x.ExamHall == hall && x.Date.Year == day.Year && x.Date.Month == day.Month && x.Date.Day == day.Day && (int)x.Date.Hour == hours && (int)x.Date.Minute == minutes);
            return !boolean;
        }

        public async Task<bool> IsValidExamNameAsync(string facultyname, string examname, int course)
        {
            var boolean = await _context.Exams.AnyAsync(x => x.Faculty.Name == facultyname && x.Title == examname && x.Course.Number == course);
            return !boolean;
        }



    }
}
