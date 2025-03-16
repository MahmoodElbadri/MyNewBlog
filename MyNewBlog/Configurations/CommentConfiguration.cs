using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNewBlog.Models;

namespace MyNewBlog.Configurations;

public class CommentConfiguration:IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(tmp => tmp.ID);
        builder.Property(tmp => tmp.Content)
            .IsRequired()
            .HasMaxLength(255)
            .HasAnnotation("MinLength", 5);

        builder.HasOne(tmp => tmp.Blog)
            .WithMany(tmp => tmp.Comments);
        builder.Property(tmp => tmp.BlogID)
            .IsRequired();
        builder.HasOne(tmp => tmp.User)
            .WithMany(tmp => tmp.Comments);
            
    }
}