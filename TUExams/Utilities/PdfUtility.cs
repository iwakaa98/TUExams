using IronPdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUExams.Models;

namespace TUExams.Utilities
{
    public class PdfUtility
    {
      
        public static string GetHTMLString(ExamListViewModel model)
        {
            var sb = new StringBuilder();
            sb.AppendFormat(@"
        <html>
        <head>

        </head>
        <body id='datatest'>
            <div>

            <center>
            <h1>Технически Университет - София</h1>
            <h3>
                Г Р А Ф И К
                <br />
                на {0} сесия за учебната {1}/{2} година
                <br />
                Курс
                <font color='#CC0333'>{3}</font>
                <br />
                <font color='#CC0333'>{4}</font>
            </h3>
        </center>
        <center>
            <table border cellspacing='0' cellpadding='2' width='700'>
                <thead>
                    <tr>
                        <td width='40%'>
                            <center>
                                <b>
                                    Дисциплина
                                </b>
                            </center>
                        </td>

                        <td width='10%'>
                            <center>
                                <b>
                                    Зала
                                </b>
                            </center>
                        </td>
                        <td width='10%'>
                            <center>
                                <b>
                                    Дата
                                </b>
                            </center>
                        </td>
                        <td width='10%'>
                            <center>
                                <b>
                                    Час
                                </b>
                            </center>
                        </td>

                        <td width='20%'>
                            <center>
                                <b>
                                    Продължителност
                                </b>
                            </center>
                        </td>
                    </tr>
                </thead>
                <tbody>
                
                        ",model.Session.ToLower(),model.Year,model.NextYear,model.CourseNumber,model.FacultyName);


            foreach (var emp in model.Exams)
            {
                sb.AppendFormat(@"
                        <tr>
                            <td>
                                <center>
                                    <b>
                                        {0}
                                    </b>
                                </center>
                            </td>
                            <td>
                                <center>
                                    <b>
                                        {1}
                                    </b>
                                </center>
                            </td>
                            <td>
                                <center>
                                    <b>
                                        {2}.{3}.{4} 
                                    </b>
                                </center>
                            </td>
                            <td>
                                <center>
                                    <b>
                                        {5}:{6}
                                    </b>
                                </center>
                            </td>
                            <td>
                                <center>
                                    <b>
                                        {7} минути
                                    </b>
                                </center>
                            </td>
                        </tr>", emp.Name, emp.ExamHall, emp.Date.Day, emp.Date.Month, emp.Date.Year, emp.Date.Hour, emp.Date.Minute.ToString("D2"), emp.Duration);
            }

            sb.Append(@"
                             </tbody>
                        </table>
                     </center>
                </div>
            </body>
        </html>");

            return sb.ToString();
        }
        
    }
}
