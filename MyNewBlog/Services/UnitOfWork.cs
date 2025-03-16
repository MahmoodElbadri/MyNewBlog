namespace MyNewBlog.Services;

public class UnitOfWork: IUnitOfWork
{
    public IBlogService BlogService { get; }
    public ICommentService CommentService { get; }
    public ILikeService LikeService { get; }
    public IUserService UserService { get; }
    public IRefreshTokenService RefreshTokenService { get; }
}