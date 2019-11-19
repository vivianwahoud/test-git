using MotorcyclesEntities;
using MotorcyclesServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotorcyclesShop.Controllers
{
    public class ProductController : Controller
    {

        ProductService productService = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductTable(string search)
        {
            var products = productService.GetProducts();
            if (string.IsNullOrEmpty(search) == false) { 
            products = products.Where(p => p.Name != null && p.Name.Contains(search)).ToList();
            }

            return PartialView(products);
        }


        // GET: 
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productService.SaveProduct(product);

            return RedirectToAction("ProductTable");
        }
        // GET: 
        [HttpGet]
        public ActionResult Edit( int ID)
        {
            var product = productService.GetProduct(ID);
            return PartialView(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productService.UpdateProduct(product);

            return RedirectToAction("ProductTable");
        }
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productService.DeleteProduct(ID);

            return RedirectToAction("ProductTable");
        }
    }
}