using System;
using System.Linq;
using System.Text.RegularExpressions;
using DataLayer.Models.BaseModels;
using DataLayer.Utils;

namespace DataLayer.Models
{
    public class FacultyUserModel : BaseUserModel
    {
        public override UserTypes UserType => UserTypes.Faculty;
        
        public override void IsValid()
        {
            base.IsValid();
            if (!Email.EndsWith("@aiub.edu"))
            {
                throw new Exception("Invalid Email. You need an email address with aiub.edu domain");
            }

            var FacultyIdFormat = new Regex("\\d{4}-\\d{4}-[1-3]$");
            if (!FacultyIdFormat.IsMatch(AcademicId))
            {
                throw new Exception("Invalid ID format. Please check your academic ID");
            }

            //if(!AcademicId.EndsWith("1") || !AcademicId.EndsWith("2") || !AcademicId.EndsWith("3"))
            //{
            //    throw new Exception("Invalid ID format. Please check your academic ID");
            //}

            if (Password.Length < 8)
            {
                throw new Exception("Weak password. Password length should be 8 at least");
            }

            if (!Password.Any(char.IsUpper) || !Password.Any(char.IsLower) || !Password.Any(char.IsDigit))
            {
                throw new Exception("Weak password. Please create a password using combination of uppercase and lowercase letters and numbers");
            }
        }
    }
}
