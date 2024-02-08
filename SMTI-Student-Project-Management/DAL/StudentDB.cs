using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections.Generic;
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
    }
}