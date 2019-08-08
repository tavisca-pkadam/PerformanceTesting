``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|             Method |     Mean |     Error |   StdDev |   Median |
|------------------- |---------:|----------:|---------:|---------:|
| PerformanceOfClass | 15.98 us | 0.4958 us | 1.357 us | 15.74 us |
| PerformaceOfStruct | 13.43 us | 1.0963 us | 3.233 us | 12.56 us |
