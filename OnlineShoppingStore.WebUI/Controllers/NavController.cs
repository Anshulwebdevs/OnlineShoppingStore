using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private readonly IProductRepository repository;
        public NavController(IProductRepository repo)
        {
            repository = repo ;
        }
        //
        // GET: /Nav/
        public PartialViewResult Menu(string catagory=null)
        {
            ViewBag.SelectedCatagory = catagory;
            IEnumerable<string> catagories = repository.Products
                                                .Select(x => x.Catagory)
                                                .Distinct()
                                                .OrderBy(x => x);
            return PartialView(catagories);
        }
	}
}