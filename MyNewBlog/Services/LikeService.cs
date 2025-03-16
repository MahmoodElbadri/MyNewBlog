using MyNewBlog.Data;
using MyNewBlog.Models;

namespace MyNewBlog.Services;

public class LikeService:Repository<Like>, ILikeService
{
    public LikeService(ApplicationDbContext db) : base(db)
    {
    }
}