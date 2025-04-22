

using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class CreatUserAccessInUserDto
{
    [Required]
    public Guid Sistema { get; set; }

    [Required]
    public Guid Role { get; set; }
}
public class CreateUserAccessDto : CreatUserAccessInUserDto
{
    public Guid UserId { get; set; }

}
public class UserAccessDto : CreateUserAccessDto
{
    public Guid Id { get; set; }

}
