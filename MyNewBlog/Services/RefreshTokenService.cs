using Microsoft.EntityFrameworkCore;
using MyNewBlog.Data;
using MyNewBlog.Models;

namespace MyNewBlog.Services;

public class RefreshTokenService:Repository<RefreshToken>,IRefreshTokenService
{
    private readonly ApplicationDbContext _db;

    public RefreshTokenService(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<bool> ValidateRefreshTokenAsync(Guid userID, string token)
    {
        var result = await _db.RefreshTokens.FirstOrDefaultAsync(tmp=>tmp.UserID == userID && tmp.Token == token);
        return result != null && result.ExpiresAt >= DateTime.Now;
    }

    public async Task<RefreshToken> GetByUserIDAsync(Guid userID)
    {
        return _db.RefreshTokens.FirstOrDefault(tmp => tmp.UserID == userID);
    }
}