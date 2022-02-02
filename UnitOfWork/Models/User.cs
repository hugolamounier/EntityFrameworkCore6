using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UnitOfWork.Models;

public static partial class ModelsBuilder
{
    public static EntityTypeBuilder<User> User(EntityTypeBuilder<User> entity)
    {
        entity.Property(p => p.FirstName).IsRequired();
        entity.Property(p => p.LastName).IsRequired();
        entity.Property(p => p.Email).IsRequired();
        entity.Property(p => p.CreatedAt).IsRequired().HasDefaultValueSql("CURRENT_TIMESTAMP");
            
        return entity;
    }
}