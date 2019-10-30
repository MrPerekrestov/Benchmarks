``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 18.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|    Method |     N |         Mean |     Error |    StdDev |
|---------- |------ |-------------:|----------:|----------:|
| **ArraySort** |  **1000** |     **7.976 us** | **0.0451 us** | **0.0422 us** |
|  ListSort |  1000 |     7.981 us | 0.0324 us | 0.0303 us |
|   OrderBy |  1000 |   139.445 us | 0.8319 us | 0.7782 us |
| **ArraySort** | **10000** |   **108.164 us** | **0.4315 us** | **0.4037 us** |
|  ListSort | 10000 |   107.516 us | 0.5021 us | 0.4696 us |
|   OrderBy | 10000 | 1,894.941 us | 7.5564 us | 7.0682 us |
