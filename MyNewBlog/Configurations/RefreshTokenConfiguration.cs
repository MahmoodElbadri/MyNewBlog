using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNewBlog.Models;

namespace MyNewBlog.Configurations;

public class RefreshTokenConfiguration:IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.HasKey(tmp=>tmp.ID);
        builder.Property(tmp => tmp.Token)
            .IsRequired()
            .HasMaxLength(255);
        builder.Property(tmp => tmp.UserID)
            .IsRequired();
        builder.Property(tmp => tmp.ExpiresAt)
            .IsRequired();
    }
}