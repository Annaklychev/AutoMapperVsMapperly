using AutoMapper;
using BenchmarkDotNet.Attributes;

namespace AutoMapperVsMapperly;

[MemoryDiagnoser]
public class MappingBenchmarks
{
    private List<User> _users = null!;
    private IMapper _autoMapper = null!;
    private UserMapper _mapperlyMapper = null!;

    [Params(100_000)]
    public int Count;
    
    [GlobalSetup]
    public void Setup()
    {
        _users = UserGenerator.GenerateUsers(Count);
        _autoMapper = MapperConfig.CreateMapper();
        _mapperlyMapper = new UserMapper();
    }

    [Benchmark(Baseline = true)]
    public List<UserDto> ManualMapping()
    {
        var result = new List<UserDto>(_users.Count);
        foreach (var u in _users)
        {
            result.Add(ManualMapper.Map(u));
        }
        return result;
    }

    [Benchmark]
    public List<UserDto> AutoMapperMapping()
    {
        var result = new List<UserDto>(_users.Count);
        foreach (var u in _users)
        {
            result.Add(_autoMapper.Map<UserDto>(u));
        }
        return result;
    }

    [Benchmark]
    public List<UserDto> MapperlyMapping()
    {
        var result = new List<UserDto>(_users.Count);
        foreach (var u in _users)
        {
            result.Add(_mapperlyMapper.ToDto(u));
        }
        return result;
    }
}