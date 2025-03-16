using MyNewBlog.Models;

namespace MyNewBlog;

public interface IRefreshTokenService: IRepository<RefreshToken>
{
    Task<bool> ValidateRefreshTokenAsync(Guid userID, string token);
    Task<RefreshToken> GetByUserIDAsync(Guid userID);
}