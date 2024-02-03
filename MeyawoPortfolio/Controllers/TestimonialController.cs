using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial

        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial p1)
        {
            db.TblTestimonial.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var deger = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetTestimonial(int id)
        {
            var media = db.TblTestimonial.Find(id);
            return View("GetTestimonial", media);
        }

        public ActionResult UpdateTestimonial(TblTestimonial t)
        {
            var urun = db.TblTestimonial.Find(t.TestimonialID);
            urun.NameSurname = t.NameSurname;
            urun.Description = t.Description;
            urun.ImgUrl = t.ImgUrl;
            urun.Status = t.Status;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}