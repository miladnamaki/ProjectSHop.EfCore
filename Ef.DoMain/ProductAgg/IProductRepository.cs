using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Core.Applicationn.Product;

namespace Ef.DoMain.ProductAgg
{
   public  interface IProductRepository
    {
        Product Get(int id);
        EditProduct GetDetalis(int id);
        void Create(Product product);
        void SaveChange();

    }
}
