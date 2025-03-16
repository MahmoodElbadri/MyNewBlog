using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MyNewBlog.Configurations;
using MyNewBlog.Models;

namespace MyNewBlog.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BlogConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new LikeConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());

    }
}