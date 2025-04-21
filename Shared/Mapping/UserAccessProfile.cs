using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Shared.Mapping;

public class UserAccessProfile : Profile
{
    public UserAccessProfile()
    {
        CreateMap<UserAccess, UserAccessDto>();
        CreateMap<UserAccessDto, UserAccess>();
    }
}
