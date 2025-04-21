using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserAccessController : ControllerBase
{
    private readonly IUserAccessService _service;

    public UserAccessController(IUserAccessService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll([FromRoute] Guid id) =>
        Ok(await _service.GetByUserIdAsync(id));

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserAccessDto dto)
    {
        await _service.AddAsync(dto);
        return Created("", null);
    }
}

