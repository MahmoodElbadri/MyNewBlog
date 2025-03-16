namespace MyNewBlog;

public interface IUnitOfWork
{
    IBlogService BlogService { get; }
    ICommentService CommentService { get; }
    ILikeService LikeService { get; }
    IUserService UserService { get; }
    IRefreshTokenService RefreshTokenService { get; }
}