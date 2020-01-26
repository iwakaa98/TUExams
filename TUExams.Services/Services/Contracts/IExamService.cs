using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TUExams.Services.Models;

namespace TUExams.Services.Services.Contracts
{
    public interface IExamService
    {
        Task CreateAsync(string facultyname, DateTime day, int hall, int duration, int course, string starttime, string examname);
        Task<ICollection<ExamDTO>> GetExamsAsync(string faculty, int course);
        Task<bool> IsValidExamNameAsync(string facultyname, string examname, int course);
        Task<bool> IsValidDayAndHallAsync(int hall, DateTime day, string starttime);
    }
}
