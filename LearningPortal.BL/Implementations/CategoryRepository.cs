using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using LearningPortal.BL.Interfaces;
using LearningPortal.Domain.Interfaces;

namespace LearningPortal.BL.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ICategoryContext context;

        public CategoryRepository(ICategoryContext cont)
        {
            context = cont;
        }

        public List<Category> GetCategoriesAndCourses()
        {
            return context.GetCategoriesAndCourses();
        }
    }
}
