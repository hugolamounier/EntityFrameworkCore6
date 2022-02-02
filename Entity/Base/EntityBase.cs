using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Base;

public abstract class EntityBase<TEntity>
{
    [Column("created_at", TypeName = "TIMESTAMP")]
    public DateTime CreatedAt { get; set; }
}