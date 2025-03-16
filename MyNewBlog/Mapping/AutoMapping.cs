using AutoMapper;
using MyNewBlog.DTOs;
using MyNewBlog.Models;

namespace MyNewBlog.Mapping;

public class AutoMapping:Profile
{
    public AutoMapping()
    {
        CreateMap<UserAddRequest, User>().ReverseMap();
        CreateMap<User,UserResponse>().ReverseMap();
        
        CreateMap<BlogAddRequest,Blog>().ReverseMap();
        CreateMap<Blog, BlogResponse>().ReverseMap();
        
        CreateMap<CommentAddRequest,Comment>().ReverseMap();
        CreateMap<Comment, CommentResponse>().ReverseMap();

        CreateMap<LikeAddRequest, Like>().ReverseMap();
        
    }
}