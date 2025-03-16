using MyNewBlog.Models;

namespace MyNewBlog;

public interface ILikeService: IRepository<Like>
{
    Task ToggleLike(Guid userID, Guid blogID);

    IEnumerable<Like> GetAllLikesByUserID(Guid userID);
}