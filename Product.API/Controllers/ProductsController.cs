using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Product.Bussiness.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductEntity.Models;
namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
      
        private ProductServices _productService;
        public ProductsController(ProductServices productService)
        {
           
            _productService = productService;
        }
        [HttpGet("GetProducts")]
        public IEnumerable<ProductEntity.Models.Product> GetProducts()
        {
            return _productService.GetProducts();
        }
        [HttpGet("GetProductById")]
        public ProductEntity.Models.Product GetProductById(int productId)
        {
            return _productService.GetProductByid(productId);
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] ProductEntity.Models.Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);

                return Ok("Status code 201 - Product created successfully!!");
            }
            else
                return BadRequest("Status Code - 406");

        }

    }
}
