``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                                          Method |      Mean |     Error |    StdDev |    Median | Rank | Rank |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------------------------------ |----------:|----------:|----------:|----------:|-----:|-----:|-------:|-------:|------:|----------:|
|              PerfromanceOfListCreateAndPopulate |  3.518 us | 0.1452 us | 0.4282 us |  3.447 us |    1 |    * | 4.0131 |      - |     - |   8.23 KB |
|     PerfromanceOfConcurrentBagCreateAndPopulate | 42.613 us | 2.5451 us | 7.5043 us | 39.696 us |    2 |   ** | 1.3428 | 0.6714 |     - |   8.25 KB |
| PerformanceTestForListCreateWithEnumerableRange |  3.607 us | 0.1683 us | 0.4773 us |  3.393 us |    1 |    * | 1.9569 |      - |     - |   4.01 KB |
|         PerformanceTestForListCreateWithForLoop |  3.412 us | 0.1345 us | 0.3924 us |  3.296 us |    1 |    * | 4.0131 |      - |     - |   8.23 KB |
