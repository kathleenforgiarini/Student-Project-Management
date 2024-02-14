using SMTI_Student_Project_Management.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMTI_Student_Project_Management.BLL
{
    public class Student
    {
        private int id;
        private string fName;
        private string lName;
        private string password;

        public Student()
        {
            Id = 0;
            FName = string.Empty;
            LName = string.Empty;
            Password = string.Empty;
        }

        public Student(int id, string fName, string lName, string password)
        {
            Id = id;
            FName = fName;
            LName = lName;
            Password = password;
        }


        public int Id { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Password { get => password; set => password = value; }

        public static Student SearchStudent(int id, string pass) => StudentDB.SearchStudent(id, pass);

        public static DataTable GetAllStudentsByProject(string projectCode) => StudentDB.GetAllStudentsByProject(projectCode);
    }
}