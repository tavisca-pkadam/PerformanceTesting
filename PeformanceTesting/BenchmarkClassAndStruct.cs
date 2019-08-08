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
    public class ClassUser
    {
        public string name;
        public int age;


        public ClassUser(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public struct StructUser
    {
        public string name;
        public int age;

        public StructUser(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public class BenchmarkClassStruct
    {
        string name;
        int age;

        [Benchmark]
        public void PerformanceOfClass()
        {
            var classUserObjectList = new List<ClassUser>();

            for (int i = 0; i < 1000; i++)
            {
                classUserObjectList.Add(new ClassUser(name = "Paresh", age = 22));
            }
        }

        [Benchmark]
        public void PerformaceOfStruct()
        {
            var structUserObjectList = new List<StructUser>();

            for (int i = 0; i < 1000; i++)
            {
                structUserObjectList.Add(new StructUser(name = "Paresh", age = 22));
            }
        }

    }
}