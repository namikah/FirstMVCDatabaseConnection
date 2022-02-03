using System.Collections.Generic;

namespace FirstMVCDatabaseConnection.Models
{
    public class Country
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
