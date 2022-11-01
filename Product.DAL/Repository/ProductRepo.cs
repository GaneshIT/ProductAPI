using Microsoft.EntityFrameworkCore;
using Product.DAL.Data;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product.DAL.Repository
{
    public class ProductRepo : IProductRepo
    {
        ProductDbContext _productDbContext;
        public ProductRepo(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }
        public bool AddProduct(ProductEntity.Models.Product product)
        {
            bool status = true;
            //Generate ProductCode
            product.ProductCode = GenerateProductCode(product);
            //sizeScaleId & colourId properties validation
            var sizeScale = _productDbContext.SizeScales.Find(product.sizeScaleId);
            foreach (var item in product.articles)
            {
                var colour = _productDbContext.colours.Find(item.ColorId);
                if (colour == null)
                {
                    status = false;break;
                }
            }
            if(sizeScale == null)
                status = false;
            if (status)
            {
                _productDbContext.Products.Add(product);
                _productDbContext.SaveChanges();
            }
            return status;
        }
        public void DeleteProduct(int productId)
        {
            var product = _productDbContext.Products.Find(productId);
            _productDbContext.Products.Remove(product);
            _productDbContext.SaveChanges();
        }

        public IEnumerable<ProductEntity.Models.Product> GetProducts()
        {
            return _productDbContext.Products.ToList();
        }
        public void UpdateProduct(ProductEntity.Models.Product product)
        {
            _productDbContext.Entry(product).State = EntityState.Modified;
            _productDbContext.SaveChanges();
        }
        public ProductEntity.Models.Product GetProductById(int productId)
        {
            return _productDbContext.Products.Find(productId);
        }

        private static int channel1Code = 001;
        private static long channel3Code = 10000000;
        private static Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public string GenerateProductCode(ProductEntity.Models.Product product)
        {
            string code = ComputeCode(product);

            while (CheckIfUnique(code))
            {
                code = ComputeCode(product);
            }
            return code;
        }

        private string ComputeCode(ProductEntity.Models.Product product)
        {
            string code;

            switch (product.ChannelId)
            {
                //productYear + three digit integer code(2022001)
                case 1:
                    code = $"{product.ProductYear}00{channel1Code}";
                    channel1Code++;
                    break;
                // 6 digit unique alphanumeric code 
                case 2:
                    code = AlphanumericGenerator(6);
                    break;
                //integer which increases sequencially
                case 3:
                    code = $"{channel3Code}";
                    channel3Code++;
                    break;

                default: code = "Invalid Code"; break;
            }
            return code;
        }
        private bool CheckIfUnique(string code)
        {
            return _productDbContext.Products.Any(x => x.ProductCode == code);
        }
        private string AlphanumericGenerator(int length)
        {
            var result = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;
        }
    }
}
