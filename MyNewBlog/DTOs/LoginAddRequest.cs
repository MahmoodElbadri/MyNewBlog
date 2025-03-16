using System.ComponentModel.DataAnnotations;

namespace MyNewBlog.DTOs;

public class LoginAddRequest
{
    [Required]
    [MinLength(3)]
    public string Username { get; set; }

    [Required]
    [MinLength(6)]
    [MaxLength(18)]
    public string Password { get; set; }
}