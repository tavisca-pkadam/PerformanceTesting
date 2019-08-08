using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace PeformanceTesting
{
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(printIL: true)]
    [RankColumn(NumeralSystem.Stars)]
    public class BenchmarkStringAndStringBuilder
    {

        [Benchmark]
        public void PerformanceTestForString()
        {
            string str = "Hello World!!";

            for (int i = 0; i < 1000; i++)
            {
                str += "!!!!";
            }
        }

        [Benchmark]
        public void PerformanceTestForStringBuilder()
        {
            StringBuilder sb = new StringBuilder("Hello World!!");

            for (int i = 0; i < 1000; i++)
            {
                sb.Append("!!!!");
            }
        }

    }
}