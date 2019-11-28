using DataAccessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    internal class ClassController : BaseController<ClassModel, ClassDataAccess>
    {
        protected override ClassDataAccess DataAccess => new ClassDataAccess();

        public List<ClassModel> GetByFacultyId(int FacultyId)
        {
            return DataAccess.GetByFacultyId(FacultyId);
        }
        public List<ClassModel> GetByDateAndFacultyId(string date, int FacultyId)
        {
            return DataAccess.GetByDateAndFacultyId(date, FacultyId);
        }

        public List<ClassModel> GetBySectionId(int SectionId)
        {
            return DataAccess.GetBySectionId(SectionId);
        }

        public void DeleteAllBySection(int SectionId)
        {
            DataAccess.DeleteAllBySection(SectionId);
        }
    }
}
