``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|   Method |     N |         Mean |     Error |    StdDev |
|--------- |------ |-------------:|----------:|----------:|
|     **Sort** |  **1000** |     **6.564 us** | **0.0243 us** | **0.0215 us** |
| SortLinq |  1000 |   133.972 us | 0.7905 us | 0.7395 us |
|     **Sort** | **10000** |    **95.706 us** | **0.5507 us** | **0.4882 us** |
| SortLinq | 10000 | 1,812.756 us | 7.5534 us | 6.3074 us |
