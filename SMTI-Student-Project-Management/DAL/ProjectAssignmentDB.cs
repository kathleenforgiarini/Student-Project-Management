using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMTI_Student_Project_Management.DAL
{
    public class ProjectAssignmentDB
    {
        internal static DataTable SearchProjectAssignments(int stId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conn;
                cmdSelect.CommandText = "SELECT pa.ProjectCode, p.ProjectTitle, CONVERT(varchar, p.Duedate, 23) AS DueDate, " +
                                              "CONVERT(varchar, pa.AssignedDate, 23) AS AssignedDate, CONVERT(varchar, pa.SubmittedDate, 23) AS SubmitedDate, pa.Grade " +
                                              "FROM ProjectAssignments pa " +
                                              "JOIN Projects p ON pa.ProjectCode = p.ProjectCode " +
                                              "WHERE pa.StudentId = @StudentId";

                using (SqlCommand command = new SqlCommand(cmdSelect.CommandText, conn))
                {
                    command.Parameters.AddWithValue("@StudentId", stId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
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