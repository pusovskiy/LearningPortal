using System.Collections.Generic;
using Common;
using LearningPortal.BL.Interfaces;
using LearningPortal.Domain.Interfaces;

namespace LearningPortal.BL.Implementations
{
    public class RepositoryLesson : IRepositoryLesson
    {
        private readonly IDbContextLesson context;

        public RepositoryLesson(IDbContextLesson cont)
        {
            context = cont;
        }

        public List<Lesson> GetLessonsByCourseID(int id)
        {
            return context.GetLessonsByCourseId(id);
        }
    }
}
