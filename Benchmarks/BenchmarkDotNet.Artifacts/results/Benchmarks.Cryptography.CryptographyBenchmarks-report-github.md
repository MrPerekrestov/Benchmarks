``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
| Method |     Mean |    Error |   StdDev |
|------- |---------:|---------:|---------:|
| Sha512 | 30.54 us | 0.137 us | 0.122 us |
|    Md5 | 21.51 us | 0.126 us | 0.118 us |
