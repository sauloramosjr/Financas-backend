using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Shared.Mapping;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<Role, RoleDto>();
        CreateMap<RoleDto, Role>();
    }
}
