using AjaxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxMVC.Controllers
{
    public class HomeController : Controller
    {
        AjaxContext db = new AjaxContext();
        public ActionResult Index()
        {
            return View(model:DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt"));
        }
        public ActionResult Timer()
        {
            return Content( DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt"));
        }
        public ActionResult getProduct()
        {
          
                var result = db.Products;
                return View(result);
        }
        public ActionResult Delete(int? id)
        {
            var getId = db.Products.SingleOrDefault(n => n.Id == id);
            if (getId != null)
            {
                db.Products.Remove(getId);
                db.SaveChanges();
                return Json(new { code = 1, mgs = string.Empty, JsonRequestBehavior.DenyGet });
            }
            else
                return Json(new { code = -1, mgs = "erro", JsonRequestBehavior.DenyGet });

        }


    }
}