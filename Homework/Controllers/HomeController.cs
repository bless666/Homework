using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (SiteCoreDBEntities db = new SiteCoreDBEntities())
            {
                ViewBag.Title = "My Blog";
                var model = db.BlogPosts.ToList();
                return View(model);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ReadOn(int Id) 
        {
            using (SiteCoreDBEntities db = new SiteCoreDBEntities())
            {
                var model = db.BlogPosts.FirstOrDefault(x => x.Id == Id);
                return View(model);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}