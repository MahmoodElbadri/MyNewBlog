using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNewBlog.Models;

namespace MyNewBlog.Configurations;

public class UserConfiguration:IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(tmp => tmp.ID);
        builder.Property(tmp => tmp.Username)
            .IsRequired()
            .HasMaxLength(255)
            .HasAnnotation("MinLength", 5);
        builder.Property(tmp => tmp.DisplayName)
            .IsRequired()
            .HasMaxLength(255)
            .HasAnnotation("MinLength", 5);
        builder.Property(tmp => tmp.PasswordHash)
            .IsRequired();
        builder.HasMany(tmp => tmp.Comments)
            .WithOne(tmp => tmp.User);
        builder.HasMany(tmp => tmp.Blogs)
            .WithOne(tmp => tmp.User);
    }
}