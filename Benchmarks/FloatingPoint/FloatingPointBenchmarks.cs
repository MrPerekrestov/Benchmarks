using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benchmarks.FloatingPoint
{
    public class FloatingPointBenchmarks
    {
        private const int N = 10000;

        [Benchmark]
        public double Log10()
        {
            double result = 0;
            for (var i = 1; i < N; i++)
            {
                result = Math.Log10(i);
            }
            return result;
        }

        [Benchmark]
        public double Division()
        {
            double result=0;
            for (var i = 1; i < N; i++)
            {
                for (var k = 1; k < N; k++)
                {
                    result = i / k;                   
                }
            }
            return result;
        }
        [Benchmark]
        public double Sqrt()
        {
            double result = 0;
            for (var i = 1; i < N; i++)
            {
                result = Math.Sqrt(i);
            }
            return result;
        }
    }
}
