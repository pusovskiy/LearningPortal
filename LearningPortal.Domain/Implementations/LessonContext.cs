using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using LearningPortal.Domain.Interfaces;

namespace LearningPortal.Domain.Implementations
{
    public class LessonContext : DbContext, ILessonContext
    {
        public List<Lesson> GetLessonsByCourseId(int courseid)
        {
            List<Lesson> result = new List<Lesson>();

            using (connection = new SqlConnection(connectString))
            {
                string sqlCommand = "exec sp_get_lessons_on_courseID @courseid";
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.Parameters.AddWithValue("@courseid", courseid);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Lesson
                        {
                            LessonName = (string) reader["LessonName"],
                            Theory = (string) reader["Theory"]
                        });
                    }
                }

            }

            return result;
        }

        public List<Lesson> GetLessonByLessonId(int lessonid)
        {
            List<Lesson> result = new List<Lesson>();

            using (connection = new SqlConnection(connectString))
            {
                string sqlCommand = "exec sp_get_lesson_by_lessonid @lessonid";
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.Parameters.AddWithValue("@lessonid", lessonid);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Lesson
                        {
                            LessonName = (string) reader["LessonName"],
                            Theory = (string) reader["Theory"]
                        });
                    }
                }

            }

            return result;
        }

    }
}
