using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            List<SelectListItem> deger1=(from x in db.TblCategory.ToList()
                                         select new SelectListItem
                                         {
                                             Text=x.CategoryName,
                                             Value = x.CategoryID.ToString()
                                         }).ToList();


 


            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject p2)
        {
            db.TblProject.Add(p2);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {
            var proje = db.TblProject.Find(id);
            db.TblProject.Remove(proje);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetProject(int id)
        {
            var deger = db.TblProject.Find(id);
            List<SelectListItem> deger2 = (from x in db.TblCategory.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();





            ViewBag.dgr2 = deger2;
            return View("GetProject", deger);
        }

        public ActionResult UpdateProject(TblProject p)
        {
            var proje = db.TblProject.Find(p.ProjectID);
            proje.Title = p.Title;
            proje.Description = p.Description;
            proje.ProjectUrl = p.ProjectUrl;
            proje.ProjectCategory = p.ProjectCategory;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

    
}