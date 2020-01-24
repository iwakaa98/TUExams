using System;
using System.Collections.Generic;
using System.Text;
using TUExams.Data.Models;
using TUExams.Services.Models;

namespace TUExams.Services.Mappers.Contracts
{
    public interface IExamDTOMapper
    {
        Exam MapFrom(ExamDTO entity);
        ExamDTO MapFrom(Exam entity);
        IList<Exam> MapFrom(ICollection<ExamDTO> entities);
        IList<ExamDTO> MapFrom(ICollection<Exam> entities);
    }
}
