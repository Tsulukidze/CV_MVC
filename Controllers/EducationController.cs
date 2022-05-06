using CV_MVC.Models.Entity;
using CV_MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_MVC.Controllers
{
  
    public class EducationController : Controller
    {
        // GET: Education
        GenericRepository<TBLEDUCATION> repo = new GenericRepository<TBLEDUCATION>();


        public ActionResult Index()
        {
            var edu = repo.List();
            return View(edu);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(TBLEDUCATION obj)
        {
            if (!ModelState.IsValid)
                return View("AddEducation");
            repo.TAdd(obj);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            TBLEDUCATION edu = repo.Find(x => x.ID == id);
            repo.TDelete(edu);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult EditEducation(int id)
        {
            TBLEDUCATION t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult EditEducation(TBLEDUCATION obj)
        {
            if (!ModelState.IsValid)
                return View("EditEducation");
            TBLEDUCATION t = repo.Find(x => x.ID == obj.ID);
            t.Header = obj.Header;
            t.SubHeader1 = obj.SubHeader1;
            t.SubHeader2 = obj.SubHeader2;
            t.Date = obj.Date;
            t.GPA = obj.GPA;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}