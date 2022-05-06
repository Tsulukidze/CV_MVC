using CV_MVC.Models.Entity;
using CV_MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_MVC.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        GenericRepository<TBLPROJECT> repo = new GenericRepository<TBLPROJECT>();
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }


        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TBLPROJECT obj)
        {
            if (!ModelState.IsValid)
                return View("AddProject");
            repo.TAdd(obj);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult GetProject(int id)
        {
            TBLPROJECT t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult GetProject(TBLPROJECT obj)
        {
            if (!ModelState.IsValid)
                return View("GetProject");
            TBLPROJECT t = repo.Find(x => x.ID == obj.ID);
            t.Project = obj.Project;
            t.Detail = obj.Detail;
            t.Link = obj.Link;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            TBLPROJECT t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }


    }
}