

using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class CreateUserAccessDto
{
    [Required]
    public Guid Sistema { get; set; }

    [Required]
    public Guid Role { get; set; }
    [Required]
    public Guid UserId { get; set; }
}
public class UserAccessDto : CreateUserAccessDto
{
    public Guid Id { get; set; }
}
