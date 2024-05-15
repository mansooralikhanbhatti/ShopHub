using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopHub.Models;
using ShopHub.entities;
using Microsoft.Identity.Client;
using System.Diagnostics.Eventing.Reader;

namespace ShopHub
{
    public class ProductController : Controller
    {
        ShopHubDBContext dbContext = new ShopHubDBContext();
        public IActionResult PList()
        {
            var product = dbContext.Products.ToList();
            return View("PList", product);
        }
        public IActionResult AddProduct(AddProductModel model)
        {
            var product = new Product();
            product.ProductName = model.Product_Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.Stock = model.Stock;

            dbContext.Add(product);
            return View(model);
        }
        [HttpPost]
        public IActionResult SaveProduct(AddProductModel model)
        {
           
                var product = new Product();
                product.ProductName = model.Product_Name;
                product.Description = model.Description;
                product.Price = model.Price;
                product.Stock = model.Stock;
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                return RedirectToAction("PList");
        }
        
        public IActionResult EditProduct(int Product_ID)
        {
            var productObj = dbContext.Products.FirstOrDefault(p => p.ProductId == Product_ID);
            var model = new AddProductModel();
            model.Product_Name = productObj.ProductName;
            model.Description = productObj.Description;
            model.Price = (int)productObj.Price;
            model.Stock = (int)productObj.Stock;

            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateProduct(AddProductModel model)
        { 
                var productObj = dbContext.Products.Where(p => p.ProductId == model.Product_ID).FirstOrDefault();
                productObj.ProductName = model.Product_Name;
                productObj.Description = model.Description;
                productObj.Price = model.Price;
                productObj.Stock = model.Stock;
                dbContext.Products.Update(productObj);
                dbContext.SaveChanges();
                return RedirectToAction("PList");
        }
        [HttpPost]
        public IActionResult DeleteProduct(int Product_ID)
        {
            var productObj = dbContext.Products.Where(p => p.ProductId == Product_ID).FirstOrDefault();
            dbContext.Remove(productObj);
            dbContext.SaveChanges();
            return Json(true);
        }
    }
}

