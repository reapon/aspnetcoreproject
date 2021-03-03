using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ashraful_CoreProject.Data;
using Ashraful_CoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ashraful_CoreProject.Controllers
{
    public class ProductAjaxController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductAjaxController(ApplicationDbContext context)
        {
            this._context = context;

        }



        public IActionResult IndexAjax()
        {
            List<ProductAjax> products = _context.ProductAjaxes.ToList();
            return View(products);
        }



        #region "Ajax Function"

        [HttpPost]
        public IActionResult DeleteProduct(string id)
        {
            ProductAjax product = _context.ProductAjaxes.Where(p => p.Code == id).FirstOrDefault();
            _context.Entry(product).State = EntityState.Deleted;
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult ViewProduct(string id)
        {
            ProductAjax product = _context.ProductAjaxes.Where(p => p.Code == id).FirstOrDefault();
            return PartialView("_detail", product);
        }

        public IActionResult EditProduct(string id)
        {
            ProductAjax product = _context.ProductAjaxes.Where(p => p.Code == id).FirstOrDefault();
            return PartialView("_Edit", product);
        }

        public IActionResult UpdateProduct(ProductAjax product)
        {
            _context.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return PartialView("_Product", product);
        }

        public IActionResult CreateProduct()
        {
            ProductAjax prod = new ProductAjax();

            return PartialView("_Create", prod);
        }

        [HttpPost]

        public IActionResult SaveProduct(ProductAjax product)
        {

            

            _context.Add(product);
            _context.SaveChanges();
            return PartialView("_Product", product);
        }

        #endregion
    }
}