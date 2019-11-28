using System.Data;
using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;

namespace DataAccessLayer
{
    public class ClassDataAccess : BaseDataAccess<ClassModel>
    {
        public override string TableName => "Classes";

        public override ClassModel Create(ClassModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Classes (Date, StartTime, EndTime, RoomNo, QRCode, QRDisplayStartTime,
                               QRDisplayEndTime, SectionId, CreatedAt) VALUES(@Date, @StartTime, @EndTime, @RoomNo, 
                                @QRCode, @QRDisplayStartTime, @QRDisplayEndTime, @SectionId, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override ClassModel Update(ClassModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Classes SET Date = @Date, StartTime = @StartTime, EndTime = EndTime,
                                RoomNo = @RoomNo WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }
    }
}
