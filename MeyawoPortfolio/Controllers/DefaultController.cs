using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblContact t)
        {
            db.TblContact.Add(t);
            db.SaveChanges();
            return View();
        }
        public PartialViewResult _HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult _NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult _FeaturePartial()
        {
            var values =db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult _AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult _ServicePartial() 
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult _ProjectPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult _JobPartial() 
        {
            
            return PartialView();
        }
        public PartialViewResult _TestimonialPartial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult _FooterPartial()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
        public PartialViewResult _ScriptPartial()
        {

            return PartialView();
        }

    }
}