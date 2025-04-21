using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Shared.Mapping;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<CreateUserDto, User>();
    }
}
