using System.ComponentModel.DataAnnotations.Schema;

namespace MyNewBlog.Models;

public class Comment
{
    public Guid ID { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    [ForeignKey(nameof(Blog))]
    public Guid BlogID { get; set; }
    public virtual Blog Blog { get; set; }
    [ForeignKey(nameof(User))]
    public Guid UserID { get; set; }
    public virtual User User { get; set; }
}