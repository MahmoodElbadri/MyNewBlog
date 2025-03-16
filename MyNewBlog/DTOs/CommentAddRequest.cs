using System.ComponentModel.DataAnnotations;
using MyNewBlog.Models;

namespace MyNewBlog.DTOs;

public class CommentAddRequest
{
    [Required]
    [MinLength(5)]
    [MaxLength(255)]
    public string? Content { get; set; } = string.Empty;
    [Required]
    public Guid BlogID { get; set; }
    [Required]
    public Guid UserID { get; set; }
}