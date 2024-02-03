using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var value =db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult GetMessage(int id)
        {
            var value=db.TblContact.Find(id);
            return View("GetMessage",value);
        }
    }
}