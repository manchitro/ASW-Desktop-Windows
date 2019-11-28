using DataAccessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    internal class SectionController : BaseController<SectionModel, SectionDataAccess>
    {
        protected override SectionDataAccess DataAccess => new SectionDataAccess();

        public List<SectionModel> GetByFaculty(FacultyUserModel faculty)
        {
            return DataAccess.GetByFaculty(faculty);
        }
    }
}
