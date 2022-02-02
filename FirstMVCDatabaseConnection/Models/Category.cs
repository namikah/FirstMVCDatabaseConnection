using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCDatabaseConnection.Models
{
    public class Category
    {
        public int Id { get; set;}

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        //public Category(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
