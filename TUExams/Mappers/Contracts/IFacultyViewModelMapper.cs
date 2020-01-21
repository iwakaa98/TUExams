using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TUExams.Models;
using TUExams.Services.Models;

namespace TUExams.Mappers.Contracts
{
    public interface IFacultyViewModelMapper
    {
        FacultyViewModel MapFrom(FacultyDTO entity);
        FacultyDTO MapFrom(FacultyViewModel enttiy);
        IList<FacultyViewModel> MapFrom(ICollection<FacultyDTO> entities);
        IList<FacultyDTO> MapFrom(ICollection<FacultyViewModel> entities);

    }
}
