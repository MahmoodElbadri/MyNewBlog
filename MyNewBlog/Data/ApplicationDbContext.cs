using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MyNewBlog.Configurations;
using MyNewBlog.Models;

namespace MyNewBlog.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BlogConfiguration());
        




    }
}