using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(model:DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt"));
        }
        public ActionResult Timer()
        {
            return Content( DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt"));
        }


    }
}