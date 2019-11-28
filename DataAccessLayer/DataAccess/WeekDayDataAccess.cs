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
    public class WeekDayDataAccess:BaseDataAccess<WeekDayModel>
    {
        public override string TableName { get; } = "WeekDays";

        public override WeekDayModel Create(WeekDayModel model)
        {
            throw new NotImplementedException();
        }

        public override WeekDayModel Update(WeekDayModel model)
        {
            throw new NotImplementedException();
        }
    }
}
