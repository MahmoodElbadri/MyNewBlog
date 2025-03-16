namespace MyNewBlog.DTOs;

public class CommentResponse
{
    public Guid ID { get; set; }
    public string? Content { get; set; }
    public Guid BlogID { get; set; }
    public Guid UserID { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}