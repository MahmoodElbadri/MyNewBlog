namespace MyNewBlog.DTOs;

public class CommentResponse
{
    public string? Content { get; set; }
    public Guid BlogID { get; set; }
    public Guid UserID { get; set; }
}