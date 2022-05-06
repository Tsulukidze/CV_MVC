using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_MVC.Models.Entity;

namespace CV_MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCVEntities db = new DbCVEntities();
        public ActionResult Index()
        {
            var values = db.TBLABOUT.ToList();
            return View(values);
        }

        public PartialViewResult About()
        {
            var obj = db.TBLABOUT.ToList();
            return PartialView(obj);
        }

        public PartialViewResult Experience()
        {
            var experiences = db.TBLEXPERIENCE.ToList();
            return PartialView(experiences);
        }

        public PartialViewResult Education()
        {
            var edu = db.TBLEDUCATION.ToList();
            return PartialView(edu);
        }

        public PartialViewResult Skill()
        {
            var skill = db.TBLSKILL.ToList();
            return PartialView(skill);
        }

        public PartialViewResult Project()
        {
            var obj = db.TBLPROJECT.ToList();
            return PartialView(obj);
        }

        public PartialViewResult Certificates()
        {
            var obj = db.TBLCERTIFICATES.ToList();
            return PartialView(obj);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Contact(TBLCONTACT obj)
        {
            obj.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLCONTACT.Add(obj);
            db.SaveChanges();
            return PartialView();
        }
    }
}