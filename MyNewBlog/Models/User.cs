namespace MyNewBlog.Models;

public class User
{
    public Guid ID { get; set; }
    public string? Username { get; set; }
    public string? DisplayName { get; set; }
    public string? PasswordHash { get; set; } = String.Empty;
    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public virtual ICollection<Blog>? Blogs { get; set; }
    public virtual ICollection<Like>? Likes { get; set; }
    public virtual ICollection<Comment>? Comments { get; set; }
}