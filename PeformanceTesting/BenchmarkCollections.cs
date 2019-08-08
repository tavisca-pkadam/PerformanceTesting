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
using System.Linq;

namespace PeformanceTesting
{
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(printIL: true)]
    [RankColumn(NumeralSystem.Stars)]
    public class BenchmarkCollections
    {


        [Benchmark]
        public void PerfromanceOfListCreateAndPopulate()
        {
            var list = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void PerfromanceOfConcurrentBagCreateAndPopulate()
        {
            var concurrentBag = new ConcurrentBag<int>();

            for (int i = 0; i < 1000; i++)
            {
                concurrentBag.Add(i);
            }
        }


        [Benchmark]
        public void PerformanceTestForListCreateWithEnumerableRange()
        {
            var ListAvailablePlaces = Enumerable.Range(0, 1000).ToList(); ;

        }

        [Benchmark]
        public void PerformanceTestForListCreateWithForLoop()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }

        }

    }
}