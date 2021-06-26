using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef.Core.Applicationn.Product;
using Ef.DoMain.ProductAgg;

namespace Ef.Core.Application.Contract
{
    public class ProductApplication : IProductApplication

    {
        private readonly IProductRepository productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public void Create(CreateProduct command)
        {
            if (productRepository.Exist(command.Name,command.CategoryId))
            {
                return;
            }

            var product = new Product(command.Name, command.UnitPrice, command.CategoryId);

            productRepository.Create(product);
            productRepository.SaveChange();
        }

        public void Remove(int id)
        {
            var product = productRepository.Get(id);
            if (product == null)
            {
                return;

            }
            productRepository.Attach(product);
            product.Remove();
            productRepository.SaveChange();
        }

        public void Resore(int id )
        {
            var product = productRepository.Get(id);
            if (product == null)
            {
                return;

            }

            productRepository.Attach(product);
            product.Restore();
            productRepository.SaveChange();
        }

        public EditProduct GetDetails(int id)
        {
            return productRepository.GetDetalis(id);
        }

        public void Edit(EditProduct command)
        {
            var product = productRepository.Get(command.Id);
            if (product==null)
            {
                return;

            }
            //productRepository.Attach(product);
            product.Edit(command.Name,command.UnitPrice,command.CategoryId);
           
            productRepository.SaveChange();

        }

        public List<ProductViewModel> Search(ProductSearchModel command)
        {
            return productRepository.Search(command);
        }
    }
}
