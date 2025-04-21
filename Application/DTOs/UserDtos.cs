using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class CreateUserDto
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    [SwaggerSchema("Nome completo do usuário")]
    public required string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [SwaggerSchema("Email válido do usuário")]
    public required string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(16,MinimumLength =4)]
    [SwaggerSchema("Password válido do usuário")]
    public required string Password { get; set; } = string.Empty;

    [Required]
    public List<CreateUserAccessDto> Acessos { get; set; } = new();
}

public class UserDto : CreateUserDto
{
    public Guid Id { get; set; }
}
