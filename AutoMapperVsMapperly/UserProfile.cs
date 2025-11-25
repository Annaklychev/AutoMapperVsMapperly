using AutoMapper;

namespace AutoMapperVsMapperly;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(d => d.FullDisplayName,
                opt => opt.MapFrom(s => $"{s.Name} ({s.Email})"));
    }
}