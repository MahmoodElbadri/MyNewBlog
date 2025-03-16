using System.ComponentModel.DataAnnotations.Schema;
namespace MyNewBlog.Models;

public class Like
{
    public Guid ID { get; set; }
    public DateTime CreatedAt { get; set; }
    [ForeignKey(nameof(User))]
    public Guid UserID { get; set; }
    public virtual User User { get; set; }
    [ForeignKey(nameof(Blog))]
    public Guid BlogID { get; set; }
    public virtual Blog Blog { get; set; }
}