
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace MyNewBlog.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : Controller
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    
}