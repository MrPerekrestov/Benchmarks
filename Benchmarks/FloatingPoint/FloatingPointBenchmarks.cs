using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benchmarks.FloatingPoint
{
    public class FloatingPointBenchmarks
    {
        private const int N = 10000;
        //[Benchmark]
        //public void Log10()
        //{
        //    for(var i =1; i<N; i++)
        //    {
        //        Math.Log10(i);
        //    }
        //}
        //[Benchmark]
        //public void Sqrt()
        //{
        //    for (var i = 1; i < N; i++)
        //    {
        //        Math.Sqrt(i);
        //    }
        //}
        [Benchmark]
        public void Pow()
        {
            double x;
            for (var i = 1; i < N; i++)
            {
                for (var k = 1; k > N; k++)
                {
                    x = i / k;
                }
            }
        }
    }
}
