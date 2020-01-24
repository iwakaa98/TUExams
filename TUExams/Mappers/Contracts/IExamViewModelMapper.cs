using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TUExams.Models;
using TUExams.Services.Models;

namespace TUExams.Mappers.Contracts
{
    public interface IExamViewModelMapper
    {
        ExamViewModel MapFrom(ExamDTO entity);
        ExamDTO MapFrom(ExamViewModel enttiy);
        IList<ExamViewModel> MapFrom(ICollection<ExamDTO> entities);
        IList<ExamDTO> MapFrom(ICollection<ExamViewModel> entities);
    }
}
