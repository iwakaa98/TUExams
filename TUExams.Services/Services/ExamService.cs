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

        public async Task CreateAsync()
        {
            await Task.Delay(0);
        }
        public async Task<ICollection<ExamDTO>> GetExamsAsync(string faculty, int course)
        {

            var exams = await _context.Exams.Where(x => x.Faculty.Name == faculty && x.Course.Number == course).ToListAsync();
            return _examDTOMapper.MapFrom(exams);
        }

       
    }
}
