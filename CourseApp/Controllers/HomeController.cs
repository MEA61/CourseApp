using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;
using CourseApp.Web.ViewModels;

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public object ProductCategoriesViewModel { get; private set; }

        public IActionResult Index()
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Kategori 1"},
                new Category(){Name="Kategori 2"},
                new Category(){Name="Kategori 3"}
            };
            var products = new List<Product>()
            {
                new Product(){Name ="Product 1"},
                new Product(){Name ="Product 2"},
                new Product(){Name ="Product 3"}
            };
            var model = new ProductsCategoriesViewModel();
            model.Products = products;
            model.Categories = categories;

            return View(model);
        }

        public IActionResult About()
        {
            var categories = new List<Category>()
            {
                new Category(){Name="Kategori 1"},
                new Category(){Name="Kategori 2"},
                new Category(){Name="Kategori 3"}
            };
            var products = new List<Product>()
            {
                new Product(){Name ="Product 1"},
                new Product(){Name ="Product 2"},
                new Product(){Name ="Product 3"}
            };
            var model = new ProductsCategoriesViewModel();
            model.Products = products;
            model.Categories = categories;

            return View(model);

        }

        public IActionResult List()
        {
            return View();
        }
    }
}