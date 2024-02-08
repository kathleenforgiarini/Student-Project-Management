using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMTI_Student_Project_Management.DAL
{
    public class TeacherDB
    {
        internal static Teacher SearchTeacher(int id, string pass)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdSearch = new SqlCommand();
                cmdSearch.Connection = conn;
                cmdSearch.CommandText = "SELECT * FROM Teachers " +
                                        "WHERE TeacherId = @TeacherId " +
                                        "AND Password = @Password";
                cmdSearch.Parameters.AddWithValue("@TeacherId", id);
                cmdSearch.Parameters.AddWithValue("@Password", pass);
                SqlDataReader reader = cmdSearch.ExecuteReader();
                Teacher teacher = new Teacher();
                if (reader.Read())
                {
                    teacher.Id = Convert.ToInt32(reader["TeacherId"]);
                    teacher.FName = reader["FirstName"].ToString();
                    teacher.LName = reader["LastName"].ToString();
                    teacher.Password = reader["Password"].ToString();
                }
                else
                {
                    teacher = null;
                }

                return teacher;
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