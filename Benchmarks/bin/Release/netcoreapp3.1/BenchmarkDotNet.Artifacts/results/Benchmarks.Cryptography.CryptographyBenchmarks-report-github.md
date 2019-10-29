``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
| Method |     Mean |    Error |   StdDev |
|------- |---------:|---------:|---------:|
| Sha256 | 56.88 us | 0.831 us | 0.777 us |
|    Md5 | 21.10 us | 0.208 us | 0.195 us |
