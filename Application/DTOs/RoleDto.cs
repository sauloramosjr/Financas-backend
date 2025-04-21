

using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class RoleDto:CreateRoleDto
{

    [Required]
    public Guid Id { get; set; }
}


public class CreateRoleDto 
{
    public Guid Id { get; set; }
}
