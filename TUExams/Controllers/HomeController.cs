using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TUExams.Mappers.Contracts;
using TUExams.Models;
using TUExams.Services.Services.Contracts;

namespace TUExams.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFacultyService _facultyService;
        private readonly IFacultyViewModelMapper _facultyViewModelMapper;

        public HomeController(IFacultyService facultyService,
            IFacultyViewModelMapper facultyViewModelMapper)
        {
            _facultyService = facultyService;
            _facultyViewModelMapper = facultyViewModelMapper;
        }

        public async Task<IActionResult> Index()
        {
            var facultiesDTO = await _facultyService.GetFacultiesAsync();
            var listviewmodel = _facultyViewModelMapper.MapFrom(facultiesDTO);
            return View(new FacultyListViewModel(listviewmodel));
        }
    }
}
