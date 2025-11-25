```

BenchmarkDotNet v0.15.6, Windows 10 (10.0.19045.6456/22H2/2022Update)
Intel Core i7-10750H CPU 2.60GHz (Max: 2.59GHz), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method            | Count  | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0      | Gen1      | Gen2     | Allocated | Alloc Ratio |
|------------------ |------- |---------:|---------:|---------:|------:|--------:|----------:|----------:|---------:|----------:|------------:|
| ManualMapping     | 100000 | 38.46 ms | 0.749 ms | 1.025 ms |  1.00 |    0.04 | 4062.5000 | 2500.0000 | 812.5000 |  20.52 MB |        1.00 |
| AutoMapperMapping | 100000 | 48.26 ms | 0.953 ms | 1.135 ms |  1.26 |    0.04 | 4000.0000 | 2272.7273 | 727.2727 |  20.52 MB |        1.00 |
| MapperlyMapping   | 100000 | 37.52 ms | 0.710 ms | 0.729 ms |  0.98 |    0.03 | 4062.5000 | 2500.0000 | 812.5000 |  20.52 MB |        1.00 |
