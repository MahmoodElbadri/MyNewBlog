using MyNewBlog.Data;
using MyNewBlog.Models;

namespace MyNewBlog.Services;

public class CommentService: Repository<Comment>, ICommentService
{
    private readonly ApplicationDbContext _db;

    public CommentService(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task Update(Comment comment)
    {
        _dbSet.Update(comment);
        await _db.SaveChangesAsync();
    }
}