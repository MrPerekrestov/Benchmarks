``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-2500K CPU 3.30GHz (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|    Method |     N |         Mean |      Error |     StdDev |
|---------- |------ |-------------:|-----------:|-----------:|
| **ArraySort** |  **1000** |     **6.602 us** |  **0.0175 us** |  **0.0164 us** |
|  ListSort |  1000 |     6.628 us |  0.0290 us |  0.0271 us |
|   OrderBy |  1000 |   136.774 us |  1.9489 us |  1.8230 us |
| **ArraySort** | **10000** |    **96.878 us** |  **0.5670 us** |  **0.5304 us** |
|  ListSort | 10000 |    97.352 us |  0.9947 us |  0.8817 us |
|   OrderBy | 10000 | 1,851.572 us | 16.9744 us | 15.0474 us |
