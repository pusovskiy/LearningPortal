using System.Collections.Generic;
using Common;
using LearningPortal.BL.Interfaces;
using LearningPortal.Domain.Interfaces;

namespace LearningPortal.BL.Implementations
{
    public class LessonRepository : ILessonRepository
    {
        private readonly ILessonContext context;

        public LessonRepository(ILessonContext cont)
        {
            context = cont;
        }

        public List<Lesson> GetLessonsByCourseID(int courseid)
        {
            return context.GetLessonsByCourseId(courseid);
        }

        public List<Lesson> GetLessonByLessonId(int lessonid)
        {
            return context.GetLessonByLessonId(lessonid);
        }
    }
}
