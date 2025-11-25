namespace AutoMapperVsMapperly;

public class UserGenerator
{
    public static List<User> GenerateUsers(int count)
    {
        var list = new List<User>(count);
        var random = new Random(42);
        var now = DateTime.UtcNow;

        for (int i = 0; i < count; i++)
        {
            list.Add(new User
            {
                Id = i + 1,
                ExternalId = Guid.NewGuid(),
                Name = $"User {i + 1}",
                Email = $"user{i + 1}@example.com",
                CreatedAt = now.AddMinutes(-random.Next(0, 100000)),
                IsActive = random.Next(0, 2) == 0,
                Balance = (decimal)(random.NextDouble() * 10000),
                Rating = random.NextDouble() * 5,
                LoginCount = random.Next(0, 1000),
                BirthDate = DateOnly.FromDateTime(
                    new DateTime(1980, 1, 1).AddDays(random.Next(0, 365 * 40)))
            });
        }

        return list;
    }
}