``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|   Method |          Mean |        Error |       StdDev |
|--------- |--------------:|-------------:|-------------:|
|    Log10 |     106.59 us |     0.703 us |     0.658 us |
| Division | 375,755.63 us | 3,410.484 us | 3,190.169 us |
|     Sqrt |      60.92 us |     0.309 us |     0.274 us |
