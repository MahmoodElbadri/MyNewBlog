using System.ComponentModel.DataAnnotations;

namespace MyNewBlog.DTOs;

public class RefreshTokenAddRequest
{
    public Guid UserID { get; set; }
    [Required]
    public string Token { get; set; }
}