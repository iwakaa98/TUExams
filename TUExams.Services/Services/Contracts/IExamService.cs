using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TUExams.Services.Models;

namespace TUExams.Services.Services.Contracts
{
    public interface IExamService
    {
         Task CreateAsync();
    }
}
