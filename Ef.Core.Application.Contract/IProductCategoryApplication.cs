using Ef.Core.Applicationn.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Core.Application.Contract
{
    public interface IProductCategoryApplication
    {
        void Create(CreateProuductCategory command);
        void Edit(EditProductCategory command);
        List<ProductCategoryViewModel> Search(string name);


    }
}
