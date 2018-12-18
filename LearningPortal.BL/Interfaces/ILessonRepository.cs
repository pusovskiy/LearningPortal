using Common;
using System.Collections.Generic;

namespace LearningPortal.BL.Interfaces
{
    public interface ILessonRepository
    {
        List<Lesson> GetLessonsByCourseID(int id);

        List<Lesson> GetLessonByLessonId(int lessonid);
    }
}
