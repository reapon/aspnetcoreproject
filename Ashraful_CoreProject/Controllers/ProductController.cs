﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ashraful_CoreProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Ashraful_CoreProject.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository db;
        private readonly IHostingEnvironment appEnvironment;

        //private ApplicationDbContext app;

        public ProductController(IProductRepository db, IHostingEnvironment appEnvironment)
        {
            this.db = db;
            this.appEnvironment = appEnvironment;

        }

        public IActionResult Index()
        {
            return View(db.GetAll());
        }

        [Authorize(Policy = "CreateRolePolicy")]


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Create(Product _product)
        {
            if (ModelState.IsValid)
            {
                string UrlImage = "";

                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;

                        var uploads = Path.Combine(appEnvironment.WebRootPath, "images");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + file.FileName;
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                UrlImage = fileName;

                            }

                        }
                    }
                }

                var data = new Product()
                {
                    Title = _product.Title,
                    EntryDate = _product.EntryDate,
                    UrlImage = UrlImage,
                    Price = _product.Price,
                    Detail = _product.Detail
                };

                db.Add(data);
                return RedirectToAction(nameof(Index));

            }

            return RedirectToAction("Index");
        }


        [Authorize(Policy = "EditRolePolicy")]

        public IActionResult Edit(int id)
        {
            return View(db.GetProduct(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<ActionResult> Edit(int id, Product _product)
        {
            if (ModelState.IsValid)
            {
                string UrlImage = "";
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;

                        var uploads = Path.Combine(appEnvironment.WebRootPath, "images");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + file.FileName;
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                UrlImage = fileName;
                            }

                        }
                    }
                }
                var data = db.GetProduct(id);
                data.Title = _product.Title;
                data.EntryDate = _product.EntryDate;
                data.Price = _product.Price;
                data.Detail = _product.Detail;
                data.UrlImage = UrlImage;

                db.Update(data);
                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            return View(db.GetProduct(id));

        }

        [Authorize(Policy = "DeleteRolePolicy")]


        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}