using System;
using System.Collections.Generic;
using System.Text;
using TUExams.Data.Models;
using TUExams.Services.Models;

namespace TUExams.Services.Mappers.Contracts
{
    public interface IFacultyDTOMapper
    {
        Faculty MapFrom(FacultyDTO entity);
        FacultyDTO MapFrom(Faculty entity);
        IList<Faculty> MapFrom(ICollection<FacultyDTO> entities);
        IList<FacultyDTO> MapFrom(ICollection<Faculty> entities);
    }
}
