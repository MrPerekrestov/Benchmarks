``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|   Method |          Mean |        Error |       StdDev |
|--------- |--------------:|-------------:|-------------:|
|    Log10 |     107.76 us |     1.287 us |     1.204 us |
| Division | 320,845.85 us | 3,874.083 us | 3,434.274 us |
|     Sqrt |      44.13 us |     0.185 us |     0.173 us |
