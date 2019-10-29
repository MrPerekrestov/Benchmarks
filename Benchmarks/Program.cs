using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarks.FloatingPoint;
using System;
using System.Security.Cryptography;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            // var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            var summary = BenchmarkRunner.Run<FloatingPointBenchmarks>();
        }
    }
}
