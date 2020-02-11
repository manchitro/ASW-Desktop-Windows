using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Sections (SectionName, FacultyId, CreatedAt) 
                                   VALUES(@SectionName, @FacultyId, @CreatedAt);
                             SELECT SCOPE_IDENTITY();";
                var newId = conn.ExecuteScalar<int>(query,model);
                model.Id = newId;
            }

            return model;
        }

        public override SectionModel Update(SectionModel model)
        {
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Sections SET SectionName = @SectionName WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }

        public List<SectionModel> GetByFaculty(FacultyUserModel faculty)
        {
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = $"SELECT * FROM Sections WHERE FacultyId = @Id";
                return conn.Query<SectionModel>(query, faculty).ToList();
            }
        }
    }
}
