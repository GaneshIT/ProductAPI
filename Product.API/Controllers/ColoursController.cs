using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Bussiness.Services;
using ProductEntity.Models;
using System.Collections.Generic;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private ColourServices _colourService;
        public ColoursController(ColourServices colourService)
        {
            _colourService = colourService;
        }
        [HttpGet("GetColours")]
        public IEnumerable<Colour> GetColours()
        {
            return _colourService.GetColours();
        }
        [HttpGet("GetColourById")]
        public Colour GetColourById(int colourId)
        {
            return _colourService.GetColourByid(colourId);
        }
        [HttpPost("AddColour")]
        public IActionResult AddColour([FromBody] Colour colour)
        {
            _colourService.AddColour(colour);
            return Ok("Colour created successfully!!");
        }
    }
}
