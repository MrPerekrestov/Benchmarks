``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|    Method |     N |         Mean |     Error |    StdDev |
|---------- |------ |-------------:|----------:|----------:|
| **ArraySort** |  **1000** |     **7.040 us** | **0.0473 us** | **0.0420 us** |
|  ListSort |  1000 |     7.181 us | 0.1352 us | 0.1198 us |
|   OrderBy |  1000 |   143.047 us | 1.7510 us | 1.6379 us |
| **ArraySort** | **10000** |   **103.018 us** | **1.1246 us** | **0.9969 us** |
|  ListSort | 10000 |   102.879 us | 0.7965 us | 0.7450 us |
|   OrderBy | 10000 | 1,911.871 us | 9.2778 us | 8.2246 us |
