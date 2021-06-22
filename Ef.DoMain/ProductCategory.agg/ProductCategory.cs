using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.DoMain.ProductAgg;

namespace Ef.DoMain.ProductCategory.agg
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public DateTime CreationDate { get; set; }
        public ProductCategory(string Name)
        {
            this.Name = Name;
            Products = new List<Product>();
            this.CreationDate = DateTime.Now;
        }

        public void Edit(string Name)
        {
            this.Name = Name;
        }

    }
}
