``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 19.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|    Method |     N |         Mean |     Error |    StdDev |
|---------- |------ |-------------:|----------:|----------:|
| **ArraySort** |  **1000** |     **45.13 us** |  **0.540 us** |  **0.479 us** |
|  ListSort |  1000 |     44.72 us |  0.309 us |  0.289 us |
|   OrderBy |  1000 |    742.58 us | 16.926 us | 15.833 us |
| **ArraySort** | **10000** |    **655.67 us** | **12.372 us** | **13.238 us** |
|  ListSort | 10000 |    707.32 us | 13.862 us | 26.707 us |
|   OrderBy | 10000 | 10,012.06 us | 81.880 us | 72.585 us |
