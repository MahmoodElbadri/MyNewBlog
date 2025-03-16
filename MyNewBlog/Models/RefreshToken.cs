namespace MyNewBlog.Models;

public class RefreshToken
{
    public Guid ID { get; set; }
    public string? Token { get; set; }
    public Guid UserID { get; set; }
    public DateTime ExpiresAt { get; set; }
}