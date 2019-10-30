``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=  2.1.200 [C:\Program Files\dotnet\sdk]
  [Host] : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT  [AttachedDebugger]


```
|   Method |     N | Mean | Error |
|--------- |------ |-----:|------:|
|    **Log10** |  **1000** |   **NA** |    **NA** |
| Division |  1000 |   NA |    NA |
|     Sqrt |  1000 |   NA |    NA |
|    **Log10** | **10000** |   **NA** |    **NA** |
| Division | 10000 |   NA |    NA |
|     Sqrt | 10000 |   NA |    NA |

Benchmarks with issues:
  FloatingPointBenchmarks.Log10: DefaultJob [N=1000]
  FloatingPointBenchmarks.Division: DefaultJob [N=1000]
  FloatingPointBenchmarks.Sqrt: DefaultJob [N=1000]
  FloatingPointBenchmarks.Log10: DefaultJob [N=10000]
  FloatingPointBenchmarks.Division: DefaultJob [N=10000]
  FloatingPointBenchmarks.Sqrt: DefaultJob [N=10000]
