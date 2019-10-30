``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|    Method |     N |         Mean |      Error |     StdDev |
|---------- |------ |-------------:|-----------:|-----------:|
| **ArraySort** |  **1000** |     **6.641 us** |  **0.0495 us** |  **0.0463 us** |
|  ListSort |  1000 |     6.612 us |  0.0356 us |  0.0316 us |
|   OrderBy |  1000 |   136.264 us |  1.7753 us |  1.6607 us |
| **ArraySort** | **10000** |    **97.156 us** |  **1.4730 us** |  **1.3058 us** |
|  ListSort | 10000 |    96.814 us |  1.0938 us |  1.0231 us |
|   OrderBy | 10000 | 1,830.410 us | 24.8533 us | 23.2478 us |
