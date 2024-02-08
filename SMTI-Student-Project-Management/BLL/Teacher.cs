using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMTI_Student_Project_Management.DAL;

namespace SMTI_Student_Project_Management.BLL
{
    public class Teacher
    {
        private int id;
        private string fName;
        private string lName;
        private string password;


        public Teacher()
        {
            this.Id = 0;
            this.FName = string.Empty;
            this.LName = string.Empty;
            this.Password = string.Empty;
        }

        public Teacher(int id, string fName, string lName, string password)
        {
            this.Id = id;
            this.FName = fName;
            this.LName = lName;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Password { get => password; set => password = value; }

        public static Teacher SearchTeacher(int id, string pass)
        {
            return TeacherDB.SearchTeacher(id, pass);
        }
    }
}