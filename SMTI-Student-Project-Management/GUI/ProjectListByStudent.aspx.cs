using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SMTI_Student_Project_Management.DAL;
using SMTI_Student_Project_Management.BLL;

namespace SMTI_Student_Project_Management.GUI
{
    public partial class ProjectListByStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "Welcome " + Session["fullname"].ToString();
            gridViewAssignedProjects.DataSource = null; 
            gridViewAssignedProjects.DataBind();
        }
    }
}