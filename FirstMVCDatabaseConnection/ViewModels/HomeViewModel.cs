﻿using FirstMVCDatabaseConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCDatabaseConnection.ViewModels
{
    public class HomeViewModel
    {
        public ICollection<Category> Categories { get; set; }


        public ICollection<Product> Products { get; set; }


        public ICollection<Country> Countries { get; set; }
    }
}
