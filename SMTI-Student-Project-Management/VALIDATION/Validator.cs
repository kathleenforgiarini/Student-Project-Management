using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SMTI_Student_Project_Management.VALIDATION
{
    public class Validator
    {
        public static bool IsValidStudentId(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{7}$"))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidTeacherId(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{5}$"))
            {
                return false;
            }
            return true;
        }
    }
}