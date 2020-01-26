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
        public async Task<IActionResult> FillExamFormAsync(ExamListViewModel vm)
        {
            var examsDTO = await _examService.GetExamsAsync(vm.FacultyName, vm.CourseNumber);
            var listviewmodel = _examViewModelMapper.MapFrom(examsDTO);
            var model = new ExamListViewModel
            {
                CourseNumber = vm.CourseNumber,
                Exams = listviewmodel,
                FacultyName = vm.FacultyName,
                Session = vm.Session,
                Year = vm.Year,
                NextYear = vm.Year + 1
            };

            var html = PdfUtility.GetHTMLString(model);

            var Renderer = new HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf(html);
            var pdfname = vm.Shortfaculty + "_" + vm.CourseNumber.ToString() + ".pdf";
            var OutputPath = "HtmlToPDF.pdf";
            PDF.SaveAs(OutputPath);

            byte[] fileBytes = System.IO.File.ReadAllBytes(@"HtmlToPDF.pdf");
            string fileName = pdfname;
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

        }
    }
}