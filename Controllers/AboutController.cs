using CV_MVC.Models.Entity;
using CV_MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_MVC.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        GenericRepository<TBLABOUT> repo = new GenericRepository<TBLABOUT>();

        [HttpGet]
        public ActionResult Index()
        {
            var obj = repo.List();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Index(TBLABOUT obj)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Name = obj.Name;
            t.Surname = obj.Surname;
            t.Adress = obj.Adress;
            t.Email = obj.Email;
            t.Phone = obj.Phone;
            t.Details = obj.Details;
            t.Photo = obj.Photo;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}