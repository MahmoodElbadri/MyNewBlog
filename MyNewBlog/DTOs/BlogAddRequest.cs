using System.ComponentModel.DataAnnotations;

namespace MyNewBlog.DTOs;

public class BlogAddRequest
{
    [Required]
    [StringLength(255)]
    [MinLength(5)]
    public string? Title { get; set; }
    [Required]
    [MinLength(5)]
    [MaxLength(255)]
    public string? Content { get; set; }
    [Required]
    public Guid UserID { get; set; }
}