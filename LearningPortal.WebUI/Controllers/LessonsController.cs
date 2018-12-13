using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using LearningPortal.BL.Interfaces;

namespace LearningPortal.WebUI.Controllers
{
    public class LessonsController : Controller
    {
        private readonly IRepositoryLesson repository;

        public LessonsController(IRepositoryLesson rep)
        {
            repository = rep;
        }
        // GET: Lessons
        public ActionResult Index(int id=1)
        {
            
            List<Lesson> model = repository.GetLessonsByCourseID(id);
            return View(model);
        }
    }
}