using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.Domain.Concrete;
using OnlineShoppingStore.Domain.Abstract;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View(repository.Products);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }
            return View(product);

        }

        public ActionResult Edit(int id)
        {
            Product product = repository.Products.FirstOrDefault(x=>x.ProductId==id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved", product.Name);
                return RedirectToAction("Index");
            }

                return View(product);
            
        }
	
    }
}
