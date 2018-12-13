using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Common;
using LearningPortal.Domain.Interfaces;

namespace LearningPortal.Domain.Implementations
{
    public class DbContextLesson : IDbContextLesson
    {
        private SqlConnection connection;
        private readonly string sqlCon= ConfigurationManager.
            ConnectionStrings["DbLearningPortal"].ConnectionString;

        public List<Lesson> GetLessonsByCourseId(int id)
        {
            List<Lesson> result = new List<Lesson>();

            using (connection=new SqlConnection(sqlCon))
            {
                string sqlCommand = "exec sp_get_lessons_on_courseID @courseid";
                SqlCommand cmd=new SqlCommand(sqlCommand,connection);
                cmd.Parameters.AddWithValue("@courseid", id);
                connection.Open();
                
                using (SqlDataReader reader=cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Lesson
                        {
                            LessonName = (string)reader["LessonName"],
                            Theory = (string)reader["Theory"]
                        });
                    }
                }

            }


            return result;
        }
    }
}
