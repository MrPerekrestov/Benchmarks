``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|    Method |     N |         Mean |      Error |     StdDev |
|---------- |------ |-------------:|-----------:|-----------:|
| **ArraySort** |  **1000** |     **7.252 us** |  **0.0547 us** |  **0.0512 us** |
|  ListSort |  1000 |     7.274 us |  0.0808 us |  0.0756 us |
|   OrderBy |  1000 |   154.043 us |  1.6570 us |  1.5500 us |
| **ArraySort** | **10000** |   **105.943 us** |  **0.8881 us** |  **0.7873 us** |
|  ListSort | 10000 |   105.692 us |  1.3778 us |  1.2888 us |
|   OrderBy | 10000 | 2,018.692 us | 18.2878 us | 17.1064 us |
