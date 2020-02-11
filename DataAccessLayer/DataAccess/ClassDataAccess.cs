﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                Console.WriteLine("Got date: " + model.ClassDate);
                var query = @"INSERT INTO Classes (ClassDate, ClassType, StartTimeId, EndTimeId, RoomNo, QRCode, QRDisplayStartTime,
                               QRDisplayEndTime, SectionId, CreatedAt) VALUES(@ClassDate, @ClassType, @StartTimeId, @EndTimeId, @RoomNo, 
                                @QRCode, @QRDisplayStartTime, @QRDisplayEndTime, @SectionId, @CreatedAt);
                             SELECT SCOPE_IDENTITY();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public List<ClassModel> GetBySectionId(int SectionId)
        {
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Classes where SectionId = @SectionId;";
                var parameters = new DynamicParameters();
                parameters.Add("@SectionId", SectionId);
                return conn.Query<ClassModel>(query, parameters).ToList();
            }
        }

        public override ClassModel Update(ClassModel model)
        {
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Classes SET ClassDate = @ClassDate, StartTimeid = @StartTimeId, EndTimeId = @EndTimeId,
                                RoomNo = @RoomNo WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }

        public List<ClassModel> GetByFacultyId(int FacultyId)
        {
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * from Classes where Id IN
                                (SELECT Id FROM Classes where SectionId IN
	                                (SELECT Id FROM Sections WHERE FacultyId = @FacultyId));";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@FacultyId", FacultyId);
                return conn.Query<ClassModel>(query, parameters).ToList();
            }
        }

        public List<ClassModel> GetByDateAndFacultyId(string date, int FacultyId)
        {
            using(SqlConnection conn = SQLiteDBConnection.Get())
            {
                //Console.WriteLine("date in query: " + date);
                var query = @"SELECT * from Classes where ClassDate = @date AND Id IN
                                (SELECT Id FROM Classes where SectionId IN
	                                (SELECT Id FROM Sections WHERE FacultyId = @FacultyId));";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@date", date);
                parameters.Add("@FacultyId", FacultyId);
                return conn.Query<ClassModel>(query, parameters).ToList();
            }
        }

        public void DeleteAllBySection (int SectionId)
        {
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"DELETE FROM Classes WHERE SectionId = @SectionId;";
                var parameters = new DynamicParameters();
                parameters.Add("@SectionId", SectionId);
                conn.Execute(query, parameters);
            }
        }

        public ClassModel InsertQRCode (int ClassId, string QR)
        {
            using(SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Classes SET QRCode = @QR WHERE Id = @ClassId;";
                var parameters = new DynamicParameters();
                parameters.Add("@ClassId", ClassId);
                parameters.Add("@QR", QR);
                return conn.ExecuteScalar<ClassModel>(query, parameters);
            }
        }

        public ClassModel InsertQRDisplayStartTime(int ClassId, string StartTime)
        {
            using(SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Classes SET QRDisplayStartTime = @StartTime where Id = @ClassId;";
                var parameters = new DynamicParameters();
                parameters.Add("@ClassId", ClassId);
                parameters.Add("@StartTime", StartTime);
                return conn.ExecuteScalar<ClassModel>(query, parameters);
            }
        }

        public ClassModel InsertQRDisplayEndTime(int ClassId, string EndTime)
        {
            using (SqlConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Classes SET QRDisplayEndTime = @EndTime where Id = @ClassId;";
                var parameters = new DynamicParameters();
                parameters.Add("@ClassId", ClassId);
                parameters.Add("@EndTime", EndTime);
                return conn.ExecuteScalar<ClassModel>(query, parameters);
            }
        }
    }
}
