``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 19.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|    Method |     N |         Mean |      Error |     StdDev |
|---------- |------ |-------------:|-----------:|-----------:|
| **ArraySort** |  **1000** |     **48.38 us** |   **0.604 us** |   **0.535 us** |
|  ListSort |  1000 |     48.06 us |   0.557 us |   0.521 us |
|   OrderBy |  1000 |    770.44 us |   5.256 us |   4.389 us |
| **ArraySort** | **10000** |    **697.82 us** |  **13.276 us** |  **16.305 us** |
|  ListSort | 10000 |    692.72 us |  11.120 us |   9.857 us |
|   OrderBy | 10000 | 10,611.99 us | 132.747 us | 124.172 us |
