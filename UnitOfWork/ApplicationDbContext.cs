using Microsoft.EntityFrameworkCore;

namespace UnitOfWork;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
}