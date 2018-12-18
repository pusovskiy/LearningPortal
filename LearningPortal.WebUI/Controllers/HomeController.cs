using Common;
using LearningPortal.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningPortal.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly log4net.ILog logger =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly ICategoryRepository repository;

        public HomeController(ICategoryRepository rep)
        {
            repository = rep;
        }

        public ActionResult Category()
        {

            List<Category> model = repository.GetCategoriesAndCourses();



            return View(model);
        }
    }
}