``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|   Method |     N |           Mean |         Error |        StdDev |
|--------- |------ |---------------:|--------------:|--------------:|
|    **Log10** |  **1000** |             **NA** |            **NA** |            **NA** |
| Division |  1000 |   4,579.139 us |    84.1614 us |    78.7246 us |
|     Sqrt |  1000 |       6.381 us |     0.1193 us |     0.1225 us |
|    **Log10** | **10000** |             **NA** |            **NA** |            **NA** |
| Division | 10000 | 454,182.847 us | 8,137.9027 us | 7,612.1992 us |
|     Sqrt | 10000 |      63.642 us |     0.2822 us |     0.2356 us |

Benchmarks with issues:
  FloatingPointBenchmarks.Log10: DefaultJob [N=1000]
  FloatingPointBenchmarks.Log10: DefaultJob [N=10000]
