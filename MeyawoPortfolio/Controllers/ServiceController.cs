using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblService.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(TblService p1)
        {
            db.TblService.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var deger = db.TblService.Find(id);
            db.TblService.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetService(int id)
        {
            var service = db.TblService.Find(id);
            return View("GetService", service);
        }

        public ActionResult UpdateService(TblService s)
        {
            var urun = db.TblService.Find(s.ServiceID);
            urun.Title = s.Title;
            urun.Description = s.Description;
            urun.ImgUrl = s.ImgUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}