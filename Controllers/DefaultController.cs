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
    }
}