using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult NewProduct(ProductsModel product)
        {
           
                return Ok();
            
            
           
           

        }

    }
}
