using Common;
using System.Collections.Generic;

namespace LearningPortal.Domain.Interfaces
{
    public interface ILessonContext
    {
        List<Lesson> GetLessonsByCourseId(int courseid);
        List<Lesson> GetLessonByLessonId(int lessonid);
    }
}
