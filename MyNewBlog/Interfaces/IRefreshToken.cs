using MyNewBlog.Models;

namespace MyNewBlog;

public interface IRefreshToken: IGeneralOperations<RefreshToken>
{
    Task<bool> ValidateRefreshTokenAsync(Guid userID, string token);
    Task<RefreshToken> GetByUserIDAsync(Guid userID);
}