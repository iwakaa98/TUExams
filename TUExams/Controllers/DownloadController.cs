using System.Threading.Tasks;
using IronPdf;
using Microsoft.AspNetCore.Mvc;
using TUExams.Mappers.Contracts;
using TUExams.Models;
using TUExams.Services.Services.Contracts;
using TUExams.Utilities;

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


        public async Task<IActionResult> FillExamFormAsync(string faculty, int course, string session, int year, string shortFaculty)
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

            var html = PdfUtility.GetHTMLString(model);

            var Renderer = new HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf(html);
            var pdfname = shortFaculty + "_" + course.ToString() + ".pdf";
            var OutputPath = "HtmlToPDF.pdf";
            PDF.SaveAs(OutputPath);

            byte[] fileBytes = System.IO.File.ReadAllBytes(@"HtmlToPDF.pdf");
            string fileName = pdfname;
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

        }
    }
}