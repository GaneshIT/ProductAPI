using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Bussiness.Services;
using ProductEntity.Models;
using System.Collections.Generic;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {
        private SizeScaleServices _sizeService;
        public SizesController(SizeScaleServices sizeService)
        {
            _sizeService = sizeService;
        }
        [HttpGet("GetSizes")]
        public IEnumerable<SizeScale> GetSizes()
        {
            return _sizeService.GetSizes();
        }
        [HttpGet("GetSizeById")]
        public SizeScale GetSizeById(int sizeId)
        {
            return _sizeService.GetSizeByid(sizeId);
        }
        [HttpPost("AddSize")]
        public IActionResult AddSize([FromBody] SizeScale size)
        {
            _sizeService.AddSize(size);
            return Ok("Size created successfully!!");
        }
    }
}
