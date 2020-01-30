using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TUExams.Mappers.Contracts;
using TUExams.Models;
using TUExams.Services.Services.Contracts;

namespace TUExams.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamService _examService;
        private readonly IFacultyService _facultyService;
        private readonly IFacultyViewModelMapper _facultyViewModelMapper;

        public ExamController(IExamService examService,
            IFacultyService facultyService, 
            IFacultyViewModelMapper facultyViewModelMapper)
        {
            _examService = examService;
            _facultyService = facultyService;
            _facultyViewModelMapper = facultyViewModelMapper;
        }

        public async Task<IActionResult> Index()
        {
            var facultiesDTO = await _facultyService.GetFacultiesAsync();
            var listviewmodel = _facultyViewModelMapper.MapFrom(facultiesDTO);
            return View(new FacultyListViewModel(listviewmodel));
        }

        public async Task<string> CreateExamAsync(string facultyname,DateTime dayy,int hall,int duration,int course,string starttime, string examname)
        {
            if(!await _examService.IsValidExamNameAsync(facultyname,examname, course))
            {
                return "false examname";
            }
            else if(!await _examService.IsValidDayAndHallAsync(hall, dayy, starttime))
            {
                return "false dayandhall";
            }
            else
            {
                await _examService.CreateAsync(facultyname, dayy, hall, duration, course, starttime, examname);
            }

            return "true";
        }
    }
}