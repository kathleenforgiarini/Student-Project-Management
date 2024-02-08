using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMTI_Student_Project_Management.DAL
{
    public class UtilityDB
    {
        //We encapsulate the database informations in the file Web.config, so that the code does not have access directly to the database informations
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            conn.Open();

            return conn;
        }
    }
}