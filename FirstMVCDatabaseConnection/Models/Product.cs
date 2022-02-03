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

        public int Quantity { get; set; }

        public Category Category { get; set; }

        public Country Country { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, double price, int quantity, Category category, Country country)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
            Country= country;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Quantity} {Category.Name}";
        }
    }
}
