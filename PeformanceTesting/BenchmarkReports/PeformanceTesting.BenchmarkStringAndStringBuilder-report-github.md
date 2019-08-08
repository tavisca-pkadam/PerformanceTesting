``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                          Method |      Mean |      Error |      StdDev |    Median | Rank | Rank |     Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------------------------- |----------:|-----------:|------------:|----------:|-----:|-----:|----------:|------:|------:|-----------:|
|        PerformanceTestForString | 652.73 us | 43.0015 us | 126.7908 us | 660.47 us |    2 |   ** | 1932.6172 |     - |     - | 3964.84 KB |
| PerformanceTestForStringBuilder |  13.65 us |  0.3217 us |   0.9487 us |  13.92 us |    1 |    * |    4.1962 |     - |     - |    8.63 KB |
