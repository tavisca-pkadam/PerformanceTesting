``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                       Method |        Mean |      Error |      StdDev | Rank | Rank |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |------------:|-----------:|------------:|-----:|-----:|--------:|------:|------:|----------:|
|      ComputationalWorkNormal |    53.72 us |  2.1056 us |   6.0075 us |    2 |   ** |       - |     - |     - |     240 B |
| ComputationalWorkUsingThread | 1,596.78 us | 43.9370 us | 128.8595 us |    3 |  *** | 27.3438 |     - |     - |     280 B |
|   ComputationalWorkUsingTask |    42.86 us |  0.8186 us |   0.7657 us |    1 |    * |  1.0376 |     - |     - |     144 B |
