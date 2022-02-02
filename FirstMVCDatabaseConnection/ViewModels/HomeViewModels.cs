using FirstMVCDatabaseConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCDatabaseConnection.ViewModels
{
    public class HomeViewModels
    {
        public ICollection<Category> Categories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
