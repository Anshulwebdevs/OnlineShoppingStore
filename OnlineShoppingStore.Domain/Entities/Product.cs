using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue=false)]
        public int ProductId { get; set; }
        [Required(ErrorMessage="This Field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public string Catagory { get; set; }
    }
}
