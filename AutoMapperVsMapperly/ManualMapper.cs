namespace AutoMapperVsMapperly;

public static class ManualMapper
{
    public static UserDto Map(User user)
        => new UserDto
        {
            Id = user.Id,
            ExternalId = user.ExternalId,
            Name = user.Name,
            Email = user.Email,
            CreatedAt = user.CreatedAt,
            IsActive = user.IsActive,
            Balance = user.Balance,
            Rating = user.Rating,
            LoginCount = user.LoginCount,
            BirthDate = user.BirthDate,
            FullDisplayName = $"{user.Name} ({user.Email})"
        };
}