using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using SMTI_Student_Project_Management.BLL;

namespace SMTI_Student_Project_Management.GUI
{
    public partial class ProjAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblName.Text = "Welcome " + Session["fullname"].ToString();
                DropDownListStudent.Items.Add("1111111, Mary Brown");
                DropDownListStudent.Items.Add("2222222, Laura White");
                DropDownListStudent.Items.Add("3333333, Richard Moore");

                DropDownListProject.Items.Add("PRJ101, Property Rental Web App");
                DropDownListProject.Items.Add("PRJ102, Order Management in C#");
                DropDownListProject.Items.Add("PRJ103, Calculator in C++");
                DropDownListProject.Items.Add("PRJ104, Online Course Registration");
            }
        }

        protected void btnListProjects_Click(object sender, EventArgs e)
        {
            try {
                string selectedStudent = DropDownListStudent.SelectedValue.ToString().Trim();
                string[] fields = selectedStudent.Split(',');
                int stId = Convert.ToInt32(fields[0]);
                GridView1.DataSource = Project.GetAllProjectsByStudent(stId);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wront", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void btnListStudents_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedProject = DropDownListProject.SelectedValue.ToString().Trim();
                string[] fields = selectedProject.Split(',');
                string prj = fields[0];
                GridView1.DataSource = Student.GetAllStudentsByProject(prj);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wront", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void btnAssignProject_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedStudent = DropDownListStudent.SelectedValue.ToString().Trim();
                string[] fieldsSt = selectedStudent.Split(',');
                int stId = Convert.ToInt32(fieldsSt[0]);
                string selectedProject = DropDownListProject.SelectedValue.ToString().Trim();
                string[] fieldsPr = selectedProject.Split(',');
                string prj = fieldsPr[0];

                if (txtAssignedDate.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Please select a date from the calendar", "Date is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime assignedDate = DateTime.Parse(txtAssignedDate.Text);

                if (ProjectAssignment.GetNumberOfProjects(stId) >= 3)
                {
                    MessageBox.Show("You can not assign more projects to this student.\nMaximum 3 projects.", "Maximum reached", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }

                ProjectAssignment projAssing = new ProjectAssignment(stId, prj, assignedDate);
                ProjectAssignment.AssignProject(projAssing);

                MessageBox.Show("Project Assigned!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView1.DataSource = Project.GetAllProjectsByStudent(stId);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wront", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;
            txtAssignedDate.Text = selectedDate.ToShortDateString();
        }
    }
}