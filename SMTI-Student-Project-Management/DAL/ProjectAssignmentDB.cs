﻿using SMTI_Student_Project_Management.BLL;
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

        internal static void AssignProject(ProjectAssignment prjAssign)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = conn;

                cmdInsert.CommandText = "INSERT INTO ProjectAssignments (StudentId, ProjectCode, AssignedDate) " +
                                        "VALUES(@StudentId,@ProjectCode,@AssignedDate)";

                cmdInsert.Parameters.AddWithValue("@StudentId", prjAssign.StudentId);
                cmdInsert.Parameters.AddWithValue("@ProjectCode", prjAssign.ProjectCode);
                cmdInsert.Parameters.AddWithValue("@AssignedDate", prjAssign.AssignedDate);
                cmdInsert.ExecuteNonQuery();

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
        internal static int GetNumberOfProjects(int stId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            int total = 0;
            try
            {
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conn;

                cmdSelect.CommandText = "SELECT COUNT(*) AS TotalAssignments FROM ProjectAssignments WHERE StudentId = @StudentId";

                cmdSelect.Parameters.AddWithValue("@StudentId", stId);
                SqlDataReader reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    total = Convert.ToInt32(reader["TotalAssignments"]);
                }
                reader.Close();

                return total;

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