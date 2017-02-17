using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using sonOfCod.Models;

namespace sonOfCod.Controllers
{
    public class HomeController : Controller
        
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Newsletter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Newsletter(MailingList mailinglist)
        {
            db.MailingLists.Add(mailinglist);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}