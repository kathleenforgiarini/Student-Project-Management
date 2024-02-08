using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMTI_Student_Project_Management.DAL;
using SMTI_Student_Project_Management.BLL;
using System.Windows.Forms;
using System.Data;

namespace SMTI_Student_Project_Management.GUI
{
    public partial class ProjectListByStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "Welcome " + Session["fullname"].ToString();
            int studentId = Convert.ToInt32(Session["id"].ToString());
            try
            {
                DataTable projects = BLL.ProjectAssignment.SearchProjectAssignments(studentId);
                gridViewAssignedProjects.DataSource = projects;
                gridViewAssignedProjects.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wront", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}