using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Ef.Core.Applicationn.Product;
using Ef.DoMain.ProductAgg;
using Microsoft.EntityFrameworkCore;

namespace Ef.Core.Infrastructure.Efcore.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly EfContext _efContext;

        public ProductRepository(EfContext efContext)
        {
            _efContext = efContext;
        }

        public void Attach(Product cmmond)
        {
            _efContext.Attach(cmmond);
        }

        public void Create(Product product) => _efContext.Products.Add(product);

        public bool Exist(string name, int categoryid)
        {
            return _efContext.Products.Any(x => x.Name == name && x.CategoryId == categoryid);
        }

        public Product Get(int id)
        {
            return _efContext.Products.AsNoTracking().FirstOrDefault(x => x.Id == id);
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
            _efContext.SaveChanges();
        }

        public List<ProductViewModel> Search(ProductSearchModel command)
        {
            var query = _efContext.Products.Include(x=>x.Category).Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                UnitPrice = x.UnitPrice,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToString(),
                Category = x.Category.Name,
                

            });
            if (command.IsRemoved==true)
            {
                query.Where(x => x.IsRemoved == true);
            }

            if (!string.IsNullOrWhiteSpace(command.Name))
            {
                query.Where(x => x.Name.Contains(command.Name));
            }

            return query.OrderByDescending(x => x.Id)
                .AsNoTracking().ToList();

            //AsNoTraking baraye ine ke tochange tracker dige taghir ijad nemikone
            // dar nahayda sorato mibare bala 
             


        }
    }
}
