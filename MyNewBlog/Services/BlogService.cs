using MyNewBlog.Data;
using MyNewBlog.Models;

namespace MyNewBlog.Services;

public class BlogService: Repository<Blog>, IBlogService
{
    private readonly ApplicationDbContext _db;

    public BlogService(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task Update(Blog blog)
    {
        _dbSet.Update(blog);
        await _db.SaveChangesAsync();
    }
}