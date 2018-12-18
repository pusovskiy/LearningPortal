using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPortal.BL.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetCategoriesAndCourses();
    }
}
