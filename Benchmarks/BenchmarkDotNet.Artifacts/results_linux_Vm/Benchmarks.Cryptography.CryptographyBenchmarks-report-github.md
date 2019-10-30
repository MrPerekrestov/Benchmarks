``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 19.04
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
| Method |     Mean |    Error |   StdDev |
|------- |---------:|---------:|---------:|
| Sha512 | 26.47 us | 0.227 us | 0.189 us |
|    Md5 | 18.03 us | 0.221 us | 0.196 us |
