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
    public class CategoryContext : DbContext , ICategoryContext
    {
        public List<Category> GetCategoriesAndCourses()
        {
            List<Category> result = new List<Category>();

            using (connection = new SqlConnection(connectString))
            {
                string sqlCommand = "exec sp_get_categories_and_courses";
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Category
                        {
                            CategoryName = (string)reader["CategoryName"],
                            CourseTitle = (string)reader["Title"]
                        });
                    }
                }

            }
            
            return result;
        }
    }
}
