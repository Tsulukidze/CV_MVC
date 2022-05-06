using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_MVC.Repositories;
using CV_MVC.Models.Entity;

namespace CV_MVC.Controllers
{
    public class CertificatesController : Controller
    {
        // GET: Certificates
        GenericRepository<TBLCERTIFICATES> repo = new GenericRepository<TBLCERTIFICATES>();
        public ActionResult Index()
        {
            var certificate = repo.List();
            return View(certificate);
        }

        public ActionResult DeleteCertificate(int id)
        {
            TBLCERTIFICATES t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetCertificate(int id)
        {
            TBLCERTIFICATES certificate = repo.Find(x => x.ID == id);
            return View(certificate);
        }

        [HttpPost]
        public ActionResult GetCertificate(TBLCERTIFICATES obj)
        {
            if (!ModelState.IsValid)
                return View("GetCertificate");
            TBLCERTIFICATES t = repo.Find(x => x.ID == obj.ID);
            t.DETAIL = obj.DETAIL;
            t.Date = obj.Date;
            repo.TUpdate(t);
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult AddCertificate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCertificate(TBLCERTIFICATES obj)
        {
            if (!ModelState.IsValid)
                return View("AddCertificate");
            repo.TAdd(obj);
            return RedirectToAction("Index");
        }


    }
}