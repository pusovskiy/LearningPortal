using Common;
using System.Collections.Generic;

namespace LearningPortal.BL.Interfaces
{
    public interface IRepositoryLesson
    {
        List<Lesson> GetLessonsByCourseID(int id);
    }
}
