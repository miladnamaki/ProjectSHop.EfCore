using Ef.Core.Applicationn.ProductCategory;
using Ef.DoMain.ProductCategory.agg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Core.Infrastructure.Efcore.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository

    {
        private readonly EfContext EfContext;

        public ProductCategoryRepository(EfContext EfContext)
        {
            this.EfContext = EfContext;
        }

        public void Create(ProductCategory productCategory)
        {
            EfContext.ProductCategories.Add(productCategory);
            SaveChange();
        }

        public bool Exist(string name)
        {
            return EfContext.ProductCategories.Any(x => x.Name == name);

        }

        public ProductCategory Get(int id)
        {
            return EfContext.ProductCategories.FirstOrDefault(x => x.Id == id);


        }

        public void SaveChange()
        {
            EfContext.SaveChanges();
        }

        public List<ProductCategoryViewModel> Search(string name)
        {
            var query = EfContext.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CreationDate = x.CreationDate.ToString()
            });
            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(X => X.Name.Contains(name));



            }
            return query.OrderByDescending(x => x.Id).ToList();

        }
    }
}
