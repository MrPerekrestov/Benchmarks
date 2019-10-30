``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 18.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|    Method |     N |         Mean |     Error |    StdDev |
|---------- |------ |-------------:|----------:|----------:|
| **ArraySort** |  **1000** |     **8.178 us** | **0.0246 us** | **0.0218 us** |
|  ListSort |  1000 |     8.135 us | 0.0390 us | 0.0365 us |
|   OrderBy |  1000 |   146.685 us | 1.0834 us | 1.0134 us |
| **ArraySort** | **10000** |   **110.181 us** | **0.4346 us** | **0.4065 us** |
|  ListSort | 10000 |   109.954 us | 0.3876 us | 0.3436 us |
|   OrderBy | 10000 | 1,973.098 us | 9.7142 us | 9.0867 us |
