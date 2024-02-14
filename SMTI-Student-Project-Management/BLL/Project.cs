using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SMTI_Student_Project_Management.DAL;

namespace SMTI_Student_Project_Management.BLL
{
    public class Project
    {
        private string code;
        private string title;
        private DateTime dueDate;

        public string Code { get => code; set => code = value; }
        public string Title { get => title; set => title = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }

        public Project() 
        {
            this.code = string.Empty;
            this.title = string.Empty;
            this.dueDate = DateTime.Now;
        }

        public Project(string code, string title, DateTime dueDate)
        {
            this.code = code;
            this.title = title;
            this.dueDate = dueDate;
        }

        public static DataTable GetAllProjectsByStudent(int stId) => ProjectDB.GetAllProjectsByStudent(stId);
    }
}