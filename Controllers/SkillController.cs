using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_MVC.Models.Entity;
using CV_MVC.Repositories;
namespace CV_MVC.Controllers
{
    public class SkillController : Controller
    {
        GenericRepository<TBLSKILL> repo = new GenericRepository<TBLSKILL>();
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(TBLSKILL obj)
        {
            if (!ModelState.IsValid)
                return View("AddSkill");
            repo.TAdd(obj);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            TBLSKILL t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            TBLSKILL t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult EditSkill(TBLSKILL obj)
        {
            if (!ModelState.IsValid)
                return View("EditSkill");
            TBLSKILL t = repo.Find(x => x.ID == obj.ID);
            t.Skill = obj.Skill;
            t.Percentage = obj.Percentage;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}