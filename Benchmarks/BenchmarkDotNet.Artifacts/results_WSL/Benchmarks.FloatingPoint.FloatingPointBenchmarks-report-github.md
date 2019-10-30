``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 18.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|   Method |          Mean |        Error |       StdDev |
|--------- |--------------:|-------------:|-------------:|
|    Log10 |     277.07 us |     1.588 us |     1.408 us |
| Division | 379,568.93 us | 1,528.400 us | 1,429.666 us |
|     Sqrt |      61.56 us |     0.174 us |     0.154 us |
