using Microsoft.EntityFrameworkCore;
using MyNewBlog.Data;
using MyNewBlog.Models;

namespace MyNewBlog.Services;

public class LikeService:Repository<Like>, ILikeService
{
    private readonly ApplicationDbContext _db;

    public LikeService(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task ToggleLike(Guid userID, Guid blogID)
    {
        var result = await _db.Likes.FirstOrDefaultAsync(tmp=>tmp.UserID == userID && tmp.BlogID == blogID);
        if (result == null)
        {
            var newLike = new Like()
            {
                UserID = userID,
                BlogID = blogID
            };
            await _dbSet.AddAsync(newLike);
            await _db.SaveChangesAsync();
        }
        else
        {
            _db.Likes.Remove(result);
            await _db.SaveChangesAsync();
        }
    }

    public IEnumerable<Like> GetAllLikesByUserID(Guid userID)
    {
        var likes = _db.Likes.Where(tmp => tmp.UserID == userID).ToList();
        return likes;
    }
}