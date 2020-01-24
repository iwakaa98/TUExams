using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TUExams.Data.Models;
using TUExams.Services.Mappers.Contracts;
using TUExams.Services.Models;

namespace TUExams.Services.Mappers
{
    public class ExamDTOMapper : IExamDTOMapper
    {
        public Exam MapFrom(ExamDTO entity)
        {
            return new Exam
            {
                Title = entity.Name,
                Date = entity.Date,
                Duration = entity.Duration,
                ExamHall = entity.ExamHall,

            };
        }

        public ExamDTO MapFrom(Exam entity)
        {
            return new ExamDTO
            {
                Name = entity.Title,
                Date = entity.Date,
                Duration = entity.Duration,
                ExamHall = entity.ExamHall,
            };
        }

        public IList<Exam> MapFrom(ICollection<ExamDTO> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }

        public IList<ExamDTO> MapFrom(ICollection<Exam> entities)
        {
            return entities.Select(this.MapFrom).ToList();
        }
    }
}
