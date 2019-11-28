using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Models;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.DBConnections;

namespace DataAccessLayer.DataAccess
{
    public class ClassTimeDataAccess : BaseDataAccess<ClassTimeModel>
    {
        public override string TableName { get; } = "ClassTimes";

        public override ClassTimeModel Create(ClassTimeModel model)
        {
            throw new NotImplementedException();
        }

        public override ClassTimeModel Update(ClassTimeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
