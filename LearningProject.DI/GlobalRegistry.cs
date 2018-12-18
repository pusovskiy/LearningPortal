using LearningPortal.BL.Implementations;
using LearningPortal.BL.Interfaces;
using StructureMap.Configuration.DSL;
using LearningPortal.Domain.Implementations;
using LearningPortal.Domain.Interfaces;

namespace LearningPortal.DI
{
    public class GlobalRegistry : Registry
    {
        public GlobalRegistry()
        {
            For<ILessonContext>().Use<LessonContext>();
            For<ILessonRepository>().Use<LessonRepository>();
            For<ICategoryContext>().Use<CategoryContext>();
            For<ICategoryRepository>().Use<CategoryRepository>();
        }
    }
}
