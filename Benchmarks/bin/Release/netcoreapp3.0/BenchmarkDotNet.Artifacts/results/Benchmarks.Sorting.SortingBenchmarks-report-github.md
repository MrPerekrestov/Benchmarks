``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.100-preview1-014459
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.0 (CoreCLR 4.700.19.50403, CoreFX 4.700.19.50410), X64 RyuJIT


```
|    Method |     N |         Mean |      Error |     StdDev |
|---------- |------ |-------------:|-----------:|-----------:|
| **ArraySort** |  **1000** |     **7.289 us** |  **0.1391 us** |  **0.1428 us** |
|  ListSort |  1000 |     7.297 us |  0.0598 us |  0.0559 us |
|   OrderBy |  1000 |   151.695 us |  2.7010 us |  2.2554 us |
| **ArraySort** | **10000** |   **106.229 us** |  **1.0137 us** |  **0.9482 us** |
|  ListSort | 10000 |   106.513 us |  1.2582 us |  1.1154 us |
|   OrderBy | 10000 | 2,025.338 us | 27.6510 us | 24.5119 us |
