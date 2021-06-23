using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Core.Applicationn.Product;
using Ef.DoMain.ProductAgg;

namespace Ef.Core.Infrastructure.Efcore.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly EfContext _efContext;

        public ProductRepository(EfContext efContext)
        {
            _efContext = efContext;
        }

        public void Create(Product product) => _efContext.Products.Add(product);




        public Product Get(int id)
        {
            return _efContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public EditProduct GetDetalis(int id)
        {
            return _efContext.Products.Select(x=> new  EditProduct
            {
                Id = x.Id,
                Name = x.Name,
                UnitPrice = x.UnitPrice,
                CategoryId = x.Id
                
            }).FirstOrDefault(x => x.Id == id);
        }

        public void SaveChange()
        {
            _efContext.SaveChanges()
        }
    }
}
