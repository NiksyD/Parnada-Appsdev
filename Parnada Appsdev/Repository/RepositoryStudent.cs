using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parnada_Appsdev.Controller;
using Parnada_Appsdev.Models;
using Microsoft.Data.SqlClient;

namespace Parnada_Appsdev.Repository
{
    public class RepositoryStudent
    {
        public readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=SigmaDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public void CreateStudent(ModelStudent modelStudent)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO StudentsPrins " +
                                 "(FirstName, MiddleName, LastName, FullName, Course, CurriculumYear, YearLevel, Semester, Remarks, Status) VALUES " +
                                 "(@FirstName, @MiddleName, @LastName, @FullName, @Course, @CurriculumYear, @YearLevel, @Semester, @Remarks, @Status);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", modelStudent.FirstName);
                        command.Parameters.AddWithValue("@MiddleName", modelStudent.MiddleName);
                        command.Parameters.AddWithValue("@LastName", modelStudent.LastName);
                        command.Parameters.AddWithValue("@FullName", modelStudent.FullName);
                        command.Parameters.AddWithValue("@Course", modelStudent.Course);
                        command.Parameters.AddWithValue("@CurriculumYear", modelStudent.CurriculumYear);
                        command.Parameters.AddWithValue("@YearLevel", modelStudent.YearLevel);
                        command.Parameters.AddWithValue("@Semester", modelStudent.Semester);
                        command.Parameters.AddWithValue("@Remarks", modelStudent.Remarks);
                        command.Parameters.AddWithValue("@Status", modelStudent.Status);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void UpdateStudent(ModelStudent modelStudent)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE StudentsPrins SET " +
                                 "FirstName = @FirstName, " +
                                 "MiddleName = @MiddleName, " +
                                 "LastName = @LastName, " +
                                 "FullName = @FullName, " +
                                 "Course = @Course, " +
                                 "CurriculumYear = @CurriculumYear, " +
                                 "YearLevel = @YearLevel, " +
                                 "Semester = @Semester, " +
                                 "Remarks = @Remarks, " +
                                 "Status = @Status " +
                                 "WHERE ID = @ID;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", modelStudent.ID);
                        command.Parameters.AddWithValue("@FirstName", modelStudent.FirstName);
                        command.Parameters.AddWithValue("@MiddleName", modelStudent.MiddleName);
                        command.Parameters.AddWithValue("@LastName", modelStudent.LastName);
                        command.Parameters.AddWithValue("@FullName", modelStudent.FullName);
                        command.Parameters.AddWithValue("@Course", modelStudent.Course);
                        command.Parameters.AddWithValue("@CurriculumYear", modelStudent.CurriculumYear);
                        command.Parameters.AddWithValue("@YearLevel", modelStudent.YearLevel);
                        command.Parameters.AddWithValue("@Semester", modelStudent.Semester);
                        command.Parameters.AddWithValue("@Remarks", modelStudent.Remarks);
                        command.Parameters.AddWithValue("@Status", modelStudent.Status);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }


        public void DeleteStudent(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM StudentsPrins WHERE ID = @ID;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        // Get all students
        public DataTable GetStudents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM StudentsPrins;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL exception: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return dt;
        }


    }
}
