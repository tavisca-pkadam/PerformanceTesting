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
|              PerfromanceOfListCreateAndPopulate |  3.197 us | 0.0636 us | 0.1677 us |  3.173 us |    1 |    * | 4.0131 |      - |     - |   8.23 KB |
|     PerfromanceOfConcurrentBagCreateAndPopulate | 37.773 us | 1.4571 us | 4.2274 us | 36.476 us |    4 | **** | 1.3428 | 0.6714 |     - |   8.25 KB |
| PerformanceTestForListCreateWithEnumerableRange |  3.341 us | 0.0659 us | 0.1238 us |  3.308 us |    2 |   ** | 1.9569 |      - |     - |   4.01 KB |
|         PerformanceTestForListCreateWithForLoop |  3.577 us | 0.0713 us | 0.1722 us |  3.612 us |    3 |  *** | 4.0131 |      - |     - |   8.23 KB |
