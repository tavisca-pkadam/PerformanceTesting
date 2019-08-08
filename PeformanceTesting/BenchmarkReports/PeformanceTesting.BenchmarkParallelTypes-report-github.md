``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742186 Hz, Resolution=364.6726 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                          Method |        Mean |       Error |     StdDev | Rank | Rank |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |------------:|------------:|-----------:|-----:|-----:|--------:|------:|------:|----------:|
|    ComputationalWorkUsingThread | 2,526.26 us | 186.8245 us | 539.031 us |    2 |   ** | 27.3438 |     - |     - |     280 B |
| DoArithematicOperationUsingTask |    44.17 us |   0.8613 us |   1.341 us |    1 |    * |  1.0376 |     - |     - |     144 B |
