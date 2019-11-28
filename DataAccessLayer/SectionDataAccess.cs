using System.Data;
using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;

namespace DataAccessLayer
{
    public class SectionDataAccess : BaseDataAccess<SectionModel>
    {
        public override string TableName => "Sections";

        public override SectionModel Create(SectionModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Sections (Name, FacultyId, CreatedAt) 
                                   VALUES(@Name, @FacultyId, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override SectionModel Update(SectionModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Sections SET Name = @Name WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }
    }
}
