using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.DoMain.ProductAgg
{
   public  interface IProductRepository
    {
        Product Get(int id);

        void Create(Product product);
    }
}
