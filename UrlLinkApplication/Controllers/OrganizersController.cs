using Microsoft.AspNetCore.Mvc;

namespace UrlLinkApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizersController : Controller
    {
        [HttpGet("{id:int}")]
        public IActionResult GetAction(int id)
        {
            return Ok($"get parameter：'{id}'");
        }
    }
}
