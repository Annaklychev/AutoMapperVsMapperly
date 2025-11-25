using AutoMapper;

namespace AutoMapperVsMapperly;

public class MapperConfig
{
    public static IMapper CreateMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<UserProfile>();
        });

        config.AssertConfigurationIsValid();

        return config.CreateMapper();
    }
}