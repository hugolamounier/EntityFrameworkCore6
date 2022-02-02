using Entity;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Models;

namespace UnitOfWork;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity => ModelsBuilder.User(entity));
    }
    
    public virtual DbSet<User> Users { get; set; }
}