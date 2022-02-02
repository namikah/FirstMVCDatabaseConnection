﻿using FirstMVCDatabaseConnection.DataAccessLayer;
using FirstMVCDatabaseConnection.Models;
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
            return View();
        }

        public IActionResult Products()
        {
            //var productList = new List<Product>
            //{
            //    new Product(1,"Mouse",2.50,100, new Category(1,"Accessories")),
            //    new Product(2,"Notebook",2,1000, new Category(2,"Computers")),
            //    new Product(3,"Iphone X",4,100, new Category(3,"Phones")),
            //    new Product(4,"Tv",2.50,100, new Category(4,"Electronics")),
            //    new Product(5,"Headphone",2.50,100, new Category(1,"Accessories")),
            //};

            var productList = _appDbContext.Products.Include(x => x.Category).ToList();

            return View(productList);
        }

        public IActionResult Categories()
        {
            var categoryList = _appDbContext.Categories.ToList();

            return View(categoryList);
        }
    }
}