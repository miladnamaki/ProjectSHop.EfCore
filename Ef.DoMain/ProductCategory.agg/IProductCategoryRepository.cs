using Ef.Core.Applicationn.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.DoMain.ProductCategory.agg
{
    public interface IProductCategoryRepository
    {
        ProductCategory Get(int id);
        bool Exist(string name);
        void Create(ProductCategory productCategory);
        void SaveChange();
        EditProductCategory GetDetails(int id);
        List<ProductCategoryViewModel> Search(string name);
        List<ProductCategoryViewModel> GetAll();
    }
}
