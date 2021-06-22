using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.DoMain.ProductAgg
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public bool IsRemoved { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory.agg.ProductCategory Category { get; set; }
        public DateTime CreationDate { get; set; }

        public Product(string name, double unitPrice, int categoryId)
        {
            Name = name;
            UnitPrice = unitPrice;
            CategoryId = categoryId;
            this.CreationDate = DateTime.Now;
        }
        public void Edit(string name, double unitPrice, int categoryId)
        {
            Name = name;
            UnitPrice = unitPrice;
            CategoryId = categoryId;
        }

        public void Remove()
        {
            this.IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;

        }
    }
}
