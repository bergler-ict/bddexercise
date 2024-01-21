using Microsoft.AspNetCore.Mvc;

namespace EshopApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        public IActionResult GetBasket()
        {
            return Ok("To be implemented");
        }
    }
}