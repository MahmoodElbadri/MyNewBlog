using MyNewBlog.Models;

namespace MyNewBlog.DTOs;

public class BlogResponse
{
    public Guid ID { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public Guid UserID { get; set; }
    public virtual ICollection<CommentResponse>? Comments { get; set; }
    public virtual ICollection<Like>? Likes { get; set; }
}