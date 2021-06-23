using Ef.Core.Applicationn.ProductCategory;
using Ef.DoMain.ProductCategory.agg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Core.Application.Contract
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository ProductCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository iProductCategoryRepository)
        {
            this.ProductCategoryRepository = iProductCategoryRepository;
        }

        public void Create(CreateProuductCategory command)
        {
            if (ProductCategoryRepository.Exist(command.name))
            {
                return;
            }

            var productcategory = new ProductCategory(command.name);
            ProductCategoryRepository.Create(productcategory);
            ProductCategoryRepository.SaveChange();
        }

        public void Edit(EditProductCategory command)
        {
            var productcategory = ProductCategoryRepository.Get(command.Id);
            if (productcategory == null)
                return;
            
            productcategory.Edit(command.name);
            ProductCategoryRepository.SaveChange();
            
        }

        public EditProductCategory GetDetails(int id)
        {
            return ProductCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(string name)
        {
            return ProductCategoryRepository.Search(name);
        }
    }
}
