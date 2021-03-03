using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ashraful_CoreProject.Data;
using Ashraful_CoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ashraful_CoreProject.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext db;
        public RegistrationController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Registration customer)
        {
            if (ModelState.IsValid)
            {
                db.Registrations.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Success");
            }

            return View(customer);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}