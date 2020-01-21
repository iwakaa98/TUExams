using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TUExams.Data.Models;
using TUExams.Services.Mappers.Contracts;
using TUExams.Services.Models;

namespace TUExams.Services.Mappers
{
    public class FacultyDTOMapper : IFacultyDTOMapper

    {
        public Faculty MapFrom(FacultyDTO entity)
        {
            return new Faculty
            {
                Id = entity.Id,
                Name = entity.Name,
                Exams = entity.Exams
            };
        }

        public FacultyDTO MapFrom(Faculty entity)
        {
            return new FacultyDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Exams = entity.Exams
            };
        }

        public IList<Faculty> MapFrom(ICollection<FacultyDTO> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }

        public IList<FacultyDTO> MapFrom(ICollection<Faculty> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }
    }
}
