using Common;
using System.Collections.Generic;

namespace LearningPortal.Domain.Interfaces
{
    public interface IDbContextLesson
    {
        List<Lesson> GetLessonsByCourseId(int id);
    }
}
