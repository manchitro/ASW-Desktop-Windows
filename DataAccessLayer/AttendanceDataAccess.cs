using System.Data;
using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;

namespace DataAccessLayer
{
    public class AttendanceDataAccess : BaseDataAccess<AttendanceModel>
    {
        public override string TableName => "Attendances";

        public override AttendanceModel Create(AttendanceModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Attendances (StudentId, ClassId, ScanTime, CreatedAt) VALUES(@StudentId, 
                                @ClassId, @ScanTime, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override AttendanceModel Update(AttendanceModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Attendances SET Date = @Date, StartTime = @StartTime, EndTime = EndTime,
                                RoomNo = @RoomNo WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }
    }
}
