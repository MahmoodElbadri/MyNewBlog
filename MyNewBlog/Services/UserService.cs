using Microsoft.EntityFrameworkCore;
using MyNewBlog.Data;
using MyNewBlog.DTOs;
using MyNewBlog.Models;

namespace MyNewBlog.Services;

public class UserService : Repository<User>, IUserService
{
    private readonly ApplicationDbContext _db;

    public UserService(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public Task<User> GetUserByUsernameAsync(string username)
    {
        return _db.Users.FirstOrDefaultAsync(tmp => tmp.Username == username);
    }

    public async Task<UserResponse> GetBlogsByUserId(Guid id)
    {
        var result = await _db.Users
            .Include(tmp => tmp.Blogs)
            .ThenInclude(tmp => tmp.Comments)
            .FirstOrDefaultAsync(tmp => tmp.ID == id);
        if (result == null) return null;
        
        return new UserResponse()
        {
            ID = result.ID,
            Username = result.Username,
            DisplayName = result.DisplayName,
            CreatedAt = result.CreatedAt,
            UpdatedAt = result.UpdatedAt,
            Blogs = result.Blogs.Select(blog => new BlogResponse()
            {
                ID = blog.ID,
                Title = blog.Title,
                Content = blog.Content,
                CreatedAt = blog.CreatedAt,
                UpdatedAt = blog.UpdatedAt,
                Comments = blog.Comments.Select(comment => new CommentResponse()
                {
                    ID = comment.ID,
                    Content = comment.Content,
                    CreatedAt = comment.CreatedAt,
                    UpdatedAt = comment.UpdatedAt
                }).ToList()
            }).ToList()
        };
    }
}