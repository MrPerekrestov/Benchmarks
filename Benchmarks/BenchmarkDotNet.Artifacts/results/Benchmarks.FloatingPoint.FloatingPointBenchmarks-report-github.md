``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 19.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|   Method |     N |           Mean |         Error |        StdDev |
|--------- |------ |---------------:|--------------:|--------------:|
|    **Log10** |  **1000** |      **55.799 us** |     **0.4052 us** |     **0.3592 us** |
| Division |  1000 |   6,409.881 us |    39.7583 us |    35.2447 us |
|     Sqrt |  1000 |       6.173 us |     0.0810 us |     0.0758 us |
|    **Log10** | **10000** |     **568.478 us** |    **10.8183 us** |    **11.1096 us** |
| Division | 10000 | 644,597.364 us | 4,341.2267 us | 4,060.7861 us |
|     Sqrt | 10000 |      61.633 us |     0.4136 us |     0.3868 us |
