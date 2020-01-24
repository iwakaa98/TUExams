using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TUExams.Mappers.Contracts;
using TUExams.Models;
using TUExams.Services.Services.Contracts;

namespace TUExams.Controllers
{
    public class DownloadController : Controller
    {
        private readonly IExamService _examService;
        private readonly IExamViewModelMapper _examViewModelMapper;

        public DownloadController(IExamService examService, IExamViewModelMapper examViewModelMapper)
        {
            _examService = examService;
            _examViewModelMapper = examViewModelMapper;
        }

        public IActionResult Exam()
        {
            return View();
        }

        public async Task<IActionResult> FillExamFormAsync(string faculty, int course, string session, int year)
        {
            var examsDTO = await _examService.GetExamsAsync(faculty, course);
            var listviewmodel = _examViewModelMapper.MapFrom(examsDTO);
            var model = new ExamListViewModel
            {
                CourseNumber = course,
                Exams = listviewmodel,
                FacultyName = faculty,
                Session = session,
                Year = year,
                NextYear = year + 1
            };
            return View("Exam", model);
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}