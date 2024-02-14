using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMTI_Student_Project_Management.DAL
{
    public class StudentDB
    {
        public static Student SearchStudent(int id, string pass)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdSearch = new SqlCommand();
                cmdSearch.Connection = conn;
                cmdSearch.CommandText = "SELECT * FROM Students " +
                                        "WHERE StudentId = @StudentId " + 
                                        "AND Password = @Password";
                cmdSearch.Parameters.AddWithValue("@StudentId", id);
                cmdSearch.Parameters.AddWithValue("@Password", pass);
                SqlDataReader reader = cmdSearch.ExecuteReader();
                Student student = new Student();
                if (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["StudentId"]);
                    student.FName = reader["FirstName"].ToString();
                    student.LName = reader["LastName"].ToString();
                    student.Password = reader["Password"].ToString();
                }
                else
                {
                    student = null;
                }

                return student;
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

        internal static DataTable GetAllStudentsByProject(string projectCode)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conn;
                cmdSelect.CommandText = "SELECT s.StudentId, s.FirstName, s.LastName " +
                                       "FROM Students s " +
                                       "JOIN ProjectAssignments pa ON s.StudentId = pa.StudentId " +
                                       "WHERE pa.ProjectCode = @ProjectCode";

                cmdSelect.Parameters.AddWithValue("@ProjectCode", projectCode);

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