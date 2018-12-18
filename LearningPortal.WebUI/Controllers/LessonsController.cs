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
        private readonly ILessonRepository repository;

        public LessonsController(ILessonRepository rep)
        {
            repository = rep;
        }
        // GET: Lessons
        public ActionResult GetLessonsByCourseId(int id=1)
        {
            
            List<Lesson> model = repository.GetLessonsByCourseID(id);
            return View(model);
        }

        


    }


}