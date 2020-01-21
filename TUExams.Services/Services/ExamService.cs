using System;
using System.Threading.Tasks;
using TUExams.Data;
using TUExams.Services.Models;
using TUExams.Services.Services.Contracts;

namespace TUExams.Services.Services
{
    public class ExamService : IExamService
    {
        private readonly TUExamContext _context;

        public ExamService(TUExamContext context)
        {
            _context = context;
        }

        public async Task CreateAsync()
        {
            await Task.Delay(0);
        }
    }
}
