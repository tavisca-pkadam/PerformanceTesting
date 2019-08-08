``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                          Method |       Mean |     Error |     StdDev | Rank | Rank |     Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------------------------- |-----------:|----------:|-----------:|-----:|-----:|----------:|------:|------:|-----------:|
|        PerformanceTestForString | 464.057 us | 9.1722 us | 15.3247 us |    2 |   ** | 1932.6172 |     - |     - | 3964.84 KB |
| PerformanceTestForStringBuilder |   7.699 us | 0.1102 us |  0.1031 us |    1 |    * |    4.2038 |     - |     - |    8.63 KB |
