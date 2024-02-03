using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;


namespace MeyawoPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia p1)
        {
            db.TblSocialMedia.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var deger = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetSocialMedia(int id)
        {
            var media = db.TblSocialMedia.Find(id);
            return View("GetSocialMedia", media);
        }

        public ActionResult UpdateSocialMedia(TblSocialMedia s)
        {
            var urun = db.TblSocialMedia.Find(s.SocialMediaID);
            urun.Title = s.Title;
            urun.SocialMediaUrl = s.SocialMediaUrl;
            urun.Icon = s.Icon;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}