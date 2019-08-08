``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|             Method |     Mean |     Error |    StdDev |    Median | Rank | Rank |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|----------:|----------:|----------:|-----:|-----:|--------:|------:|------:|----------:|
| PerformanceOfClass | 14.80 us | 0.3664 us | 1.0154 us | 14.425 us |    2 |   ** | 23.1476 |     - |     - |  47.47 KB |
| PerformaceOfStruct | 10.03 us | 0.2624 us | 0.7401 us |  9.912 us |    1 |    * | 15.6097 |     - |     - |  32.19 KB |
