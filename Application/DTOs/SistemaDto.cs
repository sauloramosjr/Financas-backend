

using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;


public class CreateSistemaDto
{
    [Required]
    public string Name { get; set; } = String.Empty;
}
public class SistemaDto
{
    public Guid Id { get; set; }
}
