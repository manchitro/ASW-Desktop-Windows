using DataAccessLayer.DBConnections;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using DataLayer.Interfaces;

namespace DataAccessLayer
{
    public class BaseDataAccess<TModel> where TModel : IModel
    {
        public List<TModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TModel Create(TModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Users (FirstName, LastName, Age, CreatedAt) 
                                   VALUES(@FirstName, @LastName, @Age, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public void Delete(int id)
        {

        }
    }
}
