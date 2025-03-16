using System.ComponentModel.DataAnnotations.Schema;

namespace MyNewBlog.Models;

public class Blog
{
    public Guid ID { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    [ForeignKey(nameof(User))]
    public Guid UserID { get; set; }
    public virtual User User { get; set; }
}