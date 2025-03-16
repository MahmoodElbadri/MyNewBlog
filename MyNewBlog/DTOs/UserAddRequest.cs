using System.ComponentModel.DataAnnotations;

namespace MyNewBlog.DTOs;

public class UserAddRequest
{
    [Required]
    [MinLength(3)]
    public string? Username { get; set; }

    [Required]
    [MinLength(3)]
    public string? DisplayName { get; set; }

    [Required]
    [MinLength(6)]
    [MaxLength(18)]
    public string? Password { get; set; }
}