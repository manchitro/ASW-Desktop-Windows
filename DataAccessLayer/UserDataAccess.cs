using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models.BaseModels;
using System;
using System.Data;
 
namespace DataAccessLayer
{
    public class UserDataAccess : BaseDataAccess<BaseUserModel>
    {
        public override string TableName { get; } = "Users";

        //public override List<BaseUserModel> Get()
        //{
        //    using (IDbConnection conn = SQLiteDBConnection.Get())
        //    {
        //        return conn.Query<dynamic, BaseUserModel, FacultyUserModel, StudentUserModel>($"SELECT * FROM {TableName}"
        //            , (baseUser, faculty, student) =>
        //        {
        //            if (baseUser.UserType == UserTypes.Faculty)
        //            {
        //                return new FacultyUserModel();
        //            }
        //            else if (p.Discriminator == "DeviceB")
        //            {
        //                return new DeviceB();
        //            }
        //            return d;
        //        });
        //    }
        //}

        public override BaseUserModel Create(BaseUserModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Users (FirstName, LastName, Email, Password, CreatedAt, UserType) 
                                   VALUES(@FirstName, @LastName, @Email, @Password, @CreatedAt, @UserType);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override BaseUserModel Update(BaseUserModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email, 
                                Password = @Password WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }

        public bool IsValidUser()
        {
            throw new NotImplementedException();
        }
    }
}
