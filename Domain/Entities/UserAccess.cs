using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

[Table("UserAccesses")]
public class UserAccess
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid UserId { get; set; }

    [Required]
    public Guid Sistema { get; set; }

    [Required]
    public Guid Role { get; set; }

    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = null!;
}
