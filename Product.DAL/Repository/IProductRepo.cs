using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DAL.Repository
{
    public interface IProductRepo
    {
        bool AddProduct(ProductEntity.Models.Product product);

        void UpdateProduct(ProductEntity.Models.Product product);

        void DeleteProduct(int productId);

        ProductEntity.Models.Product GetProductById(int productId);
        IEnumerable<ProductEntity.Models.Product> GetProducts();
        string GenerateProductCode(ProductEntity.Models.Product product);

    }
}
