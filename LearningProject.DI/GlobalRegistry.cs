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
            For<IDbContextLesson>().Use<DbContextLesson>();
            For<IRepositoryLesson>().Use<RepositoryLesson>();
        }
    }
}
