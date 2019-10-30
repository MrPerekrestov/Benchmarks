``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|   Method |          Mean |        Error |       StdDev |
|--------- |--------------:|-------------:|-------------:|
|    Log10 |     103.15 us |     0.882 us |     0.737 us |
| Division | 295,883.47 us | 1,724.682 us | 1,613.269 us |
|     Sqrt |      43.78 us |     0.277 us |     0.231 us |
