using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;
using System.Data;

namespace DataAccessLayer
{
    public class SectionTimeDataAccess : BaseDataAccess<SectionTimeModel>
    {
        public override string TableName => "Classes";

        public override SectionTimeModel Create(SectionTimeModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO SectionTimes (StartTimeId, EndTimeId, WeekDayId, ClassType, RoomNo, 
                                SectionId, CreatedAt) VALUES(@StartTimeId, @EndTimeId, @WeekDayId, @ClassType,
                                    @RoomNo, @SectionId, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override SectionTimeModel Update(SectionTimeModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE SectionTimes SET StartTimeId = @StartTimeId, EndTimeId = @EndTimeId, 
                                WeekDayId = @WeekDayId, ClassType = @ClassType, RoomNo = @RoomNo WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }
    }
}
