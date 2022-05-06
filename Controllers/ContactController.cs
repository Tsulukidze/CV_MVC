using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_MVC.Models.Entity;
using CV_MVC.Repositories;
  
namespace CV_MVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        GenericRepository<TBLCONTACT> repo = new GenericRepository<TBLCONTACT>();
        public ActionResult Index()
        {
            var message = repo.List();
            return View(message);
        }

        public ActionResult DeleteContact(int id)
        {
            TBLCONTACT t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
    }
}