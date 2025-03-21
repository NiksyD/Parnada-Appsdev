using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Parnada_Appsdev.Models;

namespace Parnada_Appsdev.Repository
{
    public class RepositoryEnrollmentHeaderFile
    {
        public readonly string _connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;";

        public DataTable GetEnrolledSubjects(long studentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                        SELECT 
                            ed.ENRDFSTUDID,  
                            ed.ENRDFSTUDSUBJCDE,  
                            sf.SFSUBJDESC,  
                            ed.ENRDFSTUDEDPCODE,  
                            ed.ENRDFSTUDSTATUS  
                        FROM EnrollmentDetailFile ed
                        JOIN SubjectFile sf ON ed.ENRDFSTUDSUBJCDE = sf.SFSUBJCODE
                        WHERE ed.ENRDFSTUDID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching enrolled subjects: " + ex.Message);
            }
            return dt;
        }

        public Result AddEnrollmentHeader(EnrollmentHeaderFile enrollmentHeader)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"
                    INSERT INTO EnrollmentHeaderFile (
                        ENRHFSTUDID, 
                        ENRHFSTUDDATEENROLL, 
                        ENRHFSTUDSCHLYR, 
                        ENRHFSTUDENCODER, 
                        ENRHFSTUDTOTALUNITS, 
                        ENRHFSTUDSTATUS
                    ) VALUES (
                        @ENRHFSTUDID, 
                        @ENRHFSTUDDATEENROLL, 
                        @ENRHFSTUDSCHLYR, 
                        @ENRHFSTUDENCODER, 
                        @ENRHFSTUDTOTALUNITS, 
                        @ENRHFSTUDSTATUS
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ENRHFSTUDID", enrollmentHeader.ENRHFSTUDID);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDDATEENROLL", enrollmentHeader.ENRHFSTUDDATEENROLL);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDSCHLYR", enrollmentHeader.ENRHFSTUDSCHLYR);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDENCODER", enrollmentHeader.ENRHFSTUDENCODER);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDTOTALUNITS", enrollmentHeader.ENRHFSTUDTOTALUNITS);
                        cmd.Parameters.AddWithValue("@ENRHFSTUDSTATUS", enrollmentHeader.ENRHFSTUDSTATUS);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                return new Result { Success = true };
            }
            catch (Exception ex)
            {
                return new Result { Success = false, ErrorMessage = ex.Message };
            }
        }

        public sealed class Result
        {
            public bool Success { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}
