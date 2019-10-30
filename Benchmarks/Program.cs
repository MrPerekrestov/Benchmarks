using BenchmarkDotNet.Running;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using BenchmarkDotNet.Loggers;
using Benchmarks.FloatingPoint;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
           //var summary = BenchmarkRunner.Run<FloatingPointBenchmarks>();            
            var summaryAll = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
        public static string GetNetCoreVersion()
        {
            var assembly = typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly;
            var assemblyPath = assembly.CodeBase.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            int netCoreAppIndex = Array.IndexOf(assemblyPath, "Microsoft.NETCore.App");
            if (netCoreAppIndex > 0 && netCoreAppIndex < assemblyPath.Length - 2)
                return assemblyPath[netCoreAppIndex + 1];
            return null;
        }
    }
}
