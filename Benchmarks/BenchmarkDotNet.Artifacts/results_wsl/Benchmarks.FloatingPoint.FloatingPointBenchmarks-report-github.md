``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 18.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|   Method |     N |           Mean |         Error |        StdDev |
|--------- |------ |---------------:|--------------:|--------------:|
|    **Log10** |  **1000** |      **30.962 us** |     **0.6701 us** |     **0.5941 us** |
| Division |  1000 |   6,341.005 us |    74.7421 us |    69.9138 us |
|     Sqrt |  1000 |       6.022 us |     0.0300 us |     0.0281 us |
|    **Log10** | **10000** |     **310.341 us** |     **1.2851 us** |     **1.2021 us** |
| Division | 10000 | 633,205.343 us | 3,081.2878 us | 2,731.4814 us |
|     Sqrt | 10000 |      60.395 us |     0.2776 us |     0.2597 us |
