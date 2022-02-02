using System.ComponentModel.DataAnnotations;
using Entity.Base;

namespace Entity;

public class User: EntityBase<User>
{
    [Key]
    public int Id { get; set; }
    [MaxLength(40)]
    public string FirstName { get; set; }
    [MaxLength(80)]
    public string LastName { get; set; }
    [MaxLength(255)]
    public string Email { get; set; }
}