using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
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
            try
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
                        Session["id"] = "";
                        Session["fullname"] = ""; 
                        Response.Redirect("ProjectAssignment.aspx");

                        break;

                    case "student":
                        if (!Validator.IsValidStudentId(id))
                        {
                            MessageBox.Show("Invalid student ID! \nPlease enter another ID", "Invalid student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBoxId.Text = "";
                            txtBoxId.Focus();
                            return;
                        }
                        Response.Redirect("ProjectListByStudent.aspx");
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wront", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}