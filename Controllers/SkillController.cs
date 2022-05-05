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
    }
}