using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarks.FloatingPoint;
using Benchmarks.Sorting;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            // var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            //var summary = BenchmarkRunner.Run<FloatingPointBenchmarks>();
            var summary = BenchmarkRunner.Run<SortingBenchmarks>();
            //var sortbench = new SortingBenchmarks();
            //sortbench.Setup();
            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //var result = sortbench.SortLinq();            
            //stopwatch.Stop();           
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            //Console.ReadKey();
        }
    }
}
