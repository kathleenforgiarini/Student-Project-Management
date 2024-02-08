using SMTI_Student_Project_Management.DAL;
using SMTI_Student_Project_Management.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMTI_Student_Project_Management.BLL
{
    public class ProjectAssignment
    {
        private int studentId;
        private string projectCode;
        private DateTime assignedDate;
        private DateTime? submittedDate;
        private int grade;
        public int StudentId { get => studentId; set => studentId = value; }
        public string ProjectCode { get => projectCode; set => projectCode = value; }
        public DateTime AssignedDate { get => assignedDate; set => assignedDate = value; }
        public DateTime? SubmittedDate { get => submittedDate; set => submittedDate = value; }
        public int Grade { get => grade; set => grade = value; }

        public ProjectAssignment()
        {
            this.studentId = 0;
            this.projectCode = string.Empty;
            this.assignedDate = DateTime.Now;
            this.submittedDate = null;
            this.grade = 0;
        }

        public ProjectAssignment(int studentId, string projectCode, DateTime assignedDate, DateTime submittedDate, int grade)
        {
            this.studentId = studentId;
            this.projectCode = projectCode;
            this.assignedDate = assignedDate;
            this.submittedDate = submittedDate;
            this.grade = grade;
        }

        public static List<ProjectAssignment> SearchProjectAssignments(int stId, string prjCode)
        {
            return ProjectAssignmentDB.SearchProjectAssignments(stId, prjCode);
        }
    }
}