using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningPortal.WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly log4net.ILog logger =
                    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // GET: Home
        public ActionResult Index()
        {
            logger.Error("In index page-HAppy logging");
            return View();
        }
    }
}