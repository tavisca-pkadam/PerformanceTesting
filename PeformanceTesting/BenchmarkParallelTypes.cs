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
using System.Threading.Tasks;
using System.Linq;

namespace PeformanceTesting
{
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(printIL: true)]
    [RankColumn(NumeralSystem.Stars)]
    public class BenchmarkParallelTypes
    {
        public static void ComputationalWork()
        {
            Enumerable.Range(1, 1000).Average();
        }


        public void ComputationalWorkNormal()
        {
            ComputationalWork();
            ComputationalWork();
            ComputationalWork();
            ComputationalWork();
            ComputationalWork();
            ComputationalWork();

        }

        [Benchmark]
        public void ComputationalWorkUsingThread()
        {
            Thread computeThread = new Thread(x =>
            {
                new Thread(_ => { ComputationalWork(); }).Start();
                new Thread(_ => { ComputationalWork(); }).Start();
                new Thread(_ => { ComputationalWork(); }).Start();
                new Thread(_ => { ComputationalWork(); }).Start();
                new Thread(_ => { ComputationalWork(); }).Start();
                new Thread(_ => { ComputationalWork(); }).Start();
            }
                );
            computeThread.Start();
            computeThread.Join();
        }

        [Benchmark]
        public void DoArithematicOperationUsingTask()
        {

            Task.Run(async () =>
                {
                    await Task.WhenAll(
                        ComputationalTaskWork(),
                        ComputationalTaskWork(),
                        ComputationalTaskWork(),
                        ComputationalTaskWork(),
                        ComputationalTaskWork(),
                        ComputationalTaskWork()
                    );

                }).GetAwaiter().GetResult();
        }

        public async static Task ComputationalTaskWork()
        {
            await Task.Run(async () =>
            {
                Enumerable.Range(1, 1000).Average();
            });
        }


    }
}