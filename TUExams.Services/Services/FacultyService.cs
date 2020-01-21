using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TUExams.Data;
using TUExams.Data.Models;
using TUExams.Services.Mappers.Contracts;
using TUExams.Services.Models;
using TUExams.Services.Services.Contracts;

namespace TUExams.Services.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly TUExamContext _context;
        private readonly IFacultyDTOMapper _facultyDTOMapper;

        public FacultyService(TUExamContext context, IFacultyDTOMapper facultyDTOMapper)
        {
            _context = context;
            _facultyDTOMapper = facultyDTOMapper;
        }

        public async Task<ICollection<FacultyDTO>> GetFacultiesAsync()
        {
            
            var faculties = await _context.Faculties.ToListAsync();

            return _facultyDTOMapper.MapFrom(faculties);
        }
    }
}
