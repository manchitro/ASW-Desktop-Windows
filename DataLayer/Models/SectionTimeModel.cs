﻿using DataLayer.Models.BaseModels;
using DataLayer.Utils;
using System;
using System.Linq;

namespace DataLayer.Models
{
    public class SectionTimeModel : BaseModel
    {
        public int StartTimeId { get; set; }
        public int EndTimeId { get; set; }
        public ClassTypes ClassType { get; set; }
        public string RoomNo { get; set; }
        public int SectionId { get; set; }
        public int WeekDayID { get; set; }

        public override void IsValid()
        {

            if(!(ClassType == ClassTypes.Lab || ClassType == ClassTypes.Theory))
            {
                throw new Exception("Invalid class type");
            }
            if(StartTimeId > EndTimeId)
            {
                throw new Exception("Startng time cannnot be after ending time");
            }
            if(EndTimeId - StartTimeId < 2)
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
