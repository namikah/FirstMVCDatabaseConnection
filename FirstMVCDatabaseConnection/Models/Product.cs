using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCDatabaseConnection.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public Category Category { get; set; }

        //public Product(int id, string name, double price, int count, Category category)
        //{
        //    Id = id;
        //    Name = name;
        //    Price = price;
        //    Count = count;
        //    Category = category;
        //}

        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Count} {Category.Name}";
        }
    }
}
