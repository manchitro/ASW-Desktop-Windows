﻿using DataLayer.Models.BaseModels;
using DataLayer.Utils;
using System;
using System.Linq;

namespace DataLayer.Models
{
    public class ClassModel : BaseModel
    {
        public string ClassDate { set; get; }
        public int StartTimeId { set; get; }
        public int EndTimeId { set; get; }
        public ClassTypes ClassType { set; get; }
        public string RoomNo { set; get; }
        public string QRCode { set; get; }
        public string QRDisplayStartTime { set; get; }
        public string QRDisplayEndTime { set; get; }
        public int SectionID { set; get; }

        public override void IsValid()
        {
            if (DateTime.Parse(ClassDate) < DateTime.Today)
            {
                throw new Exception("Class date cannot be set in the past");
            }
            if (!(ClassType == ClassTypes.Lab || ClassType == ClassTypes.Theory))
            {
                throw new Exception("Invalid class type");
            }
            if (StartTimeId > EndTimeId)
            {
                throw new Exception("Startng time cannnot be after ending time");
            }
            if (EndTimeId - StartTimeId < 2)
            {
                throw new Exception("Class length cannot be shorter than an hour");
            }
            if (String.IsNullOrWhiteSpace(RoomNo))
            {
                throw new Exception("Please Enter Room No.");
            }
            if (!RoomNo.Any(char.IsDigit))
            {
                throw new Exception("Invalid Room No. Please check again. Make sure room no has at least one digit in it");
            }

        }
    }
}
