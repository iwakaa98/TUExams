using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TUExams.Models
{
    public class FacultyListViewModel
    {
        public FacultyListViewModel(IList<FacultyViewModel> list)
        {
            this.FacultyViewModels = list;
        }
        public ICollection<FacultyViewModel> FacultyViewModels { get; set; }
    }
}
