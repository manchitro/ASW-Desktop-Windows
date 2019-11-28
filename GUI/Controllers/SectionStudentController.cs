using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Controllers.BaseController
{
    public class SectionStudentController
    {
        protected SectionStudentDataAccess DataAccess => new SectionStudentDataAccess();

        public void Create(int SectionId, int StudentId)
        {
            DataAccess.Create(SectionId, StudentId);
        }

        public void Remove(int SectionId, int StudentId)
        {
            DataAccess.Remove(SectionId, StudentId);
        }

        public void RemoveAllBySection(int SectionId)
        {
            DataAccess.RemoveAllBySection(SectionId);
        }

        public List<int> GetAllBySection(int SectionId)
        {
            return DataAccess.GetAllBySection(SectionId);
        }
    }
}
