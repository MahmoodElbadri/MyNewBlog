using MyNewBlog.Models;

namespace MyNewBlog.DTOs;

public class UserResponse
{
    public Guid ID { get; set; }
    public string? Username { get; set; }
    public string? DisplayName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public virtual ICollection<BlogResponse> Blogs { get; set; } = [];
    public virtual ICollection<CommentResponse> Comments { get; set; } = [];
    public virtual ICollection<Like> Likes { get; set; } = [];
}