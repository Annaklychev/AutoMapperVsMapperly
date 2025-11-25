using Riok.Mapperly.Abstractions;

namespace AutoMapperVsMapperly;

[Mapper]
public partial class UserMapper
{
    [MapProperty(nameof(User.Name), nameof(UserDto.Name))]
    public partial UserDto ToDto(User user);

    // Можно без атрибутов, Mapperly по совпадающим именам сам замапит
    // Тут отдельно укажем FullDisplayName:
    [ObjectFactory]
    private static UserDto CreateUserDto(User user)
        => new UserDto
        {
            FullDisplayName = $"{user.Name} ({user.Email})"
        };
}