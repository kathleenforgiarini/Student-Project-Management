using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SMTI_Student_Project_Management.DAL
{
    public class ProjectDB
    {
        internal static DataTable GetAllProjectsByStudent(int stId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conn;
                cmdSelect.CommandText = "SELECT p.ProjectCode, p.ProjectTitle, CONVERT(varchar, p.Duedate, 23) AS DueDate " +
                                       "FROM Projects p " +
                                       "JOIN ProjectAssignments pa ON p.ProjectCode = pa.ProjectCode " +
                                       "WHERE pa.StudentId = @StudentId";

                cmdSelect.Parameters.AddWithValue("@StudentId", stId);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect))
                {
                    adapter.Fill(dt);
                }

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}