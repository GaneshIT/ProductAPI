using Product.DAL.Data;
using Product.DAL.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;


namespace Product.Bussiness.Services
{
    public class ProductServices
    {
        IProductRepo _productRepo; 
        public ProductServices(IProductRepo productRepository)
        {
            _productRepo = productRepository;
        }
        public void AddProduct(ProductEntity.Models.Product product)
        {
            _productRepo.AddProduct(product);
        }
        public void UpdateProduct(ProductEntity.Models.Product product)
        {
            _productRepo.UpdateProduct(product);
        }
        public void DeleteProduct(int productId)
        {
            _productRepo.DeleteProduct(productId);
        }

        public IEnumerable<ProductEntity.Models.Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }
        public ProductEntity.Models.Product GetProductByid(int productId)
        {
            return _productRepo.GetProductById(productId);
        }
    }
}
