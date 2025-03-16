using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNewBlog.Models;

namespace MyNewBlog.Configurations;

public class LikeConfiguration:IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.HasKey(tmp => tmp.ID);

        builder.HasOne(tmp => tmp.User)
            .WithMany(tmp => tmp.Likes)
            .HasForeignKey(tmp => tmp.UserID)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(tmp => tmp.Blog)
            .WithMany(tmp => tmp.Likes)
            .HasForeignKey(tmp => tmp.BlogID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}