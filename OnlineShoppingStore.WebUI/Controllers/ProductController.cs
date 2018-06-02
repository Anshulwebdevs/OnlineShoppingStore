using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize=2;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        //
        // GET: /Product/
        public ActionResult List(string catagory,int page=1)
        {
            ProductsListViewModel model2 = new ProductsListViewModel
            {
                
                 Products= repository.Products
                 .Where(p=> catagory==null || p.Catagory==catagory)
                .OrderBy(m=>m.ProductId)
                .Skip((page-1)*PageSize)
                .Take(PageSize),
                pagingInfo=new PagingInfo
                {
                    CurrentPage=page,
                    ItemsPerPage=PageSize,
                    TotalItems = repository.Products
                                .Where(p => catagory == null || p.Catagory == catagory)
                                .Count()
                },
                CurrentCatagory=catagory

            };
            

            return View(model2);
        }
	}
}