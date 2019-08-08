using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;


using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace PeformanceTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<IntroParams>();
            var benchmarkClassStruct = BenchmarkRunner.Run<BenchmarkClassStruct>();
            var benchmakrCollections = BenchmarkRunner.Run<BenchmarkCollections>();
            var benchmarkParallelTypes = BenchmarkRunner.Run<BenchmarkParallelTypes>();
            var benchmarkStringAndStringBuilder = BenchmarkRunner.Run<BenchmarkStringAndStringBuilder>();

            Console.ReadKey(true);
        }

        
    }

}
