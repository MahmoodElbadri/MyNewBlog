
using Microsoft.AspNetCore.Mvc;

namespace MyNewBlog.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Hello World");
    }
}