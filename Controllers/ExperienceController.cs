using CV_MVC.Models.Entity;
using CV_MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_MVC.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TBLEXPERIENCE obj)
        {
            if (!ModelState.IsValid)
                return View("AddExperience");
            repo.TAdd(obj);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            TBLEXPERIENCE t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetExperience(int id)
        {
            TBLEXPERIENCE t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult GetExperience(TBLEXPERIENCE obj)
        {
            if (!ModelState.IsValid)
                return View("GetExperience");
            TBLEXPERIENCE t = repo.Find(x => x.ID == obj.ID);
            t.Header = obj.Header;
            t.SubHeader = obj.SubHeader;
            t.Date = obj.Date;
            t.Details = obj.Details;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }


    }

}