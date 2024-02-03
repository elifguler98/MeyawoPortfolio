using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(TblCategory p1)
        {
            db.TblCategory.Add(p1);
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
           var deger = db.TblCategory.Find(id);
            db.TblCategory.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCategory(int id) 
        {
            var urundeger = db.TblCategory.Find(id);
            return View("GetCategory", urundeger);
        }

        public ActionResult UpdateCategory(TblCategory p)
        {
            var urun = db.TblCategory.Find(p.CategoryID);
            urun.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}