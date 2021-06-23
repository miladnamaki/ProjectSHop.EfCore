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
        bool Exist(string name ,int  categoryid);
        List<ProductViewModel> Search(ProductSearchModel command);
        void Attach(Product cmmond); //baraye inke betonim az asnotraking baraye edit kardan estgefade konim
    }
}
