using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Core.Applicationn.Product
{
    public interface IProductApplication
    {
        void Create( CreateProduct command);
        void Remove(int id);
        void Resore(int id );

        EditProduct GetDetails(int id );

        void Edit(EditProduct command);
        List<ProductViewModel> Search(ProductSearchModel command);



    }
}
