using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TUExams.Mappers.Contracts;
using TUExams.Models;
using TUExams.Services.Models;

namespace TUExams.Mappers
{
    public class FacultyViewModelMapper : IFacultyViewModelMapper
    {
        public FacultyViewModel MapFrom(FacultyDTO entity)
        {
            return new FacultyViewModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public FacultyDTO MapFrom(FacultyViewModel enttiy)
        {
            return new FacultyDTO
            {
                Id = enttiy.Id,
                Name = enttiy.Name
            };
        }

        public IList<FacultyViewModel> MapFrom(ICollection<FacultyDTO> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }

        public IList<FacultyDTO> MapFrom(ICollection<FacultyViewModel> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }
    }
}
