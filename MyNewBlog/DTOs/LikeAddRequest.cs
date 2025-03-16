using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyNewBlog.Models;

namespace MyNewBlog.DTOs;

public class LikeAddRequest
{
    [Required]
    public Guid UserID { get; set; }
    [Required]
    public Guid BlogID { get; set; }
}