using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TUExams.Mappers.Contracts;
using TUExams.Models;
using TUExams.Services.Models;

namespace TUExams.Mappers
{
    public class ExamViewModelMapper : IExamViewModelMapper
    {
        public ExamViewModel MapFrom(ExamDTO entity)
        {
            return new ExamViewModel
            {
                Name = entity.Name,
                Date = entity.Date,
                Hour = entity.Date.Hour,
                Minutes = entity.Date.Minute.ToString("D2"),
                Duration = entity.Duration,
                ExamHall = entity.ExamHall,

            };
        }

        public ExamDTO MapFrom(ExamViewModel entity)
        {
            return new ExamDTO
            {
                Name = entity.Name,
                Date = entity.Date,
                Duration = entity.Duration,
                ExamHall = entity.ExamHall,
            };
        }

        public IList<ExamViewModel> MapFrom(ICollection<ExamDTO> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }

        public IList<ExamDTO> MapFrom(ICollection<ExamViewModel> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }
    }
}
