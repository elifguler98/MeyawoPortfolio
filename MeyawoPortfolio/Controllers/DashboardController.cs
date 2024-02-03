using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var pdeger=db.TblProject.Count().ToString();
            ViewBag.pdeger = pdeger;

            var kdeger = db.TblCategory.Count().ToString();
            ViewBag.kdeger = kdeger;

            var sdeger = db.TblService.Count().ToString();
            ViewBag.sdeger = sdeger;

            var mdeger = db.TblContact.Count().ToString();
            ViewBag.mdeger = mdeger;



            return View();
        }
        public PartialViewResult _ProjectList()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult _CategoryList()
        {
            var values = db.TblCategory.ToList();
            return PartialView(values);
        }
        public PartialViewResult _ServiceList()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult _MessageList()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }

    }
}