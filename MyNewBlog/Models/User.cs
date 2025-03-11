namespace MyNewBlog.Models;

public class User
{
    public Guid ID { get; set; }
    public string? Username { get; set; }
    public string? DisplayName { get; set; }
    public string? PasswordHash { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual ICollection<Blog> Blogs { get; set; }
}