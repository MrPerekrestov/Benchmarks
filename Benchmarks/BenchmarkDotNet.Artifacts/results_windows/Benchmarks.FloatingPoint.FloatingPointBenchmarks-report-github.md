``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|   Method |     N |           Mean |         Error |        StdDev |
|--------- |------ |---------------:|--------------:|--------------:|
|    **Log10** |  **1000** |      **11.393 us** |     **0.0268 us** |     **0.0224 us** |
| Division |  1000 |   6,463.568 us |    36.4196 us |    34.0670 us |
|     Sqrt |  1000 |       6.187 us |     0.0587 us |     0.0549 us |
|    **Log10** | **10000** |     **112.465 us** |     **0.7382 us** |     **0.6905 us** |
| Division | 10000 | 635,557.385 us | 5,304.6483 us | 4,429.6216 us |
|     Sqrt | 10000 |      60.591 us |     0.3809 us |     0.3563 us |
