using FirstMVCDatabaseConnection.DataAccessLayer;
using FirstMVCDatabaseConnection.Models;
using FirstMVCDatabaseConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCDatabaseConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var products = _appDbContext.Products.Include(x => x.Category).Include(x=>x.Country).ToList();
            var categories = _appDbContext.Categories.ToList();
            var Countries = _appDbContext.Country.ToList();

            return View(new HomeViewModel
            {
                Products = products,
                Categories = categories,
                Countries = Countries
            });
        }

        public IActionResult Products()
        {
            var products = _appDbContext.Products.Include(x => x.Category).Include(x => x.Country).ToList();

            return View(products);
        }

        public IActionResult Categories()
        {
            var categories = _appDbContext.Categories.ToList();

            return View(categories);
        }

        public IActionResult Countries()
        {
            var Countries = _appDbContext.Country.ToList();

            return View(Countries);
        }
    }
}
