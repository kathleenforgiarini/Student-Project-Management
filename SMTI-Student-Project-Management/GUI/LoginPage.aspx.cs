using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using SMTI_Student_Project_Management.BLL;
using SMTI_Student_Project_Management.VALIDATION;

namespace SMTI_Student_Project_Management.GUI
{
    public partial class LoginPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string type = radioType.SelectedValue.ToString();
            string id = txtBoxId.Text.Trim();
            string password = txtBoxPassword.Text.Trim();
            
            switch (type)
            {
                case "teacher":
                    if (!Validator.IsValidTeacherId(id))
                    {
                        MessageBox.Show("Invalid teacher ID! \nPlease enter another ID", "Invalid teacher ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxId.Text = "";
                        txtBoxId.Focus();
                        return;
                    }
                    int tcId = Convert.ToInt32(id);
                    Teacher teacher = Teacher.SearchTeacher(tcId, password);

                    if (teacher == null)
                    {
                        MessageBox.Show("Invalid credencials for teacher!", "Invalid crendencials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxId.Text = "";
                        txtBoxPassword.Text = "";
                        txtBoxId.Focus();
                        return;
                    }

                    Session["id"] = teacher.Id.ToString();
                    Session["fullname"] = teacher.FName.ToString() + " " + teacher.LName.ToString();

                    if (Page.IsValid)
                    {
                        Response.Redirect("ProjAssignment.aspx");
                    }

                    break;

                case "student":
                    if (!Validator.IsValidStudentId(id))
                    {
                        MessageBox.Show("Invalid student ID! \nPlease enter another ID", "Invalid student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxId.Text = "";
                        txtBoxId.Focus();
                        return;
                    }
                    int stId = Convert.ToInt32(id);
                    Student student = Student.SearchStudent(stId, password);

                    if (student == null)
                    {
                        MessageBox.Show("Invalid credencials for student!", "Invalid crendencials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxId.Text = "";
                        txtBoxPassword.Text = "";
                        txtBoxId.Focus();
                        return;
                    }

                    Session["id"] = student.Id.ToString();
                    Session["fullname"] = student.FName.ToString() + " " + student.LName.ToString();
                        
                    if (Page.IsValid)
                    {
                        Response.Redirect("ProjectListByStudent.aspx");
                    }

                    break;

                default:
                    break;
            }
            
        }
    }
}