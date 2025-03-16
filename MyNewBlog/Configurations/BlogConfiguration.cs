using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNewBlog.Models;

namespace MyNewBlog.Configurations;

public class BlogConfiguration:IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.HasKey(tmp => tmp.ID);
        builder.Property(tmp => tmp.Title)
            .IsRequired()
            .HasMaxLength(255)
            .HasAnnotation("MinLength", 5);
        builder.Property(tmp => tmp.Content)
            .IsRequired()
            .HasAnnotation("MinLength", 5)
            .HasMaxLength(255);
        builder.HasOne(tmp => tmp.User)
            .WithMany(tmp => tmp.Blogs)
            .HasForeignKey(tmp => tmp.UserID)
            .OnDelete(DeleteBehavior.Cascade);

    }
}