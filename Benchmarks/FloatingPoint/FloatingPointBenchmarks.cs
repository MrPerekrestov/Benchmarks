using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Benchmarks.FloatingPoint
{
    public class FloatingPointBenchmarks
    {
       
        [Params(1000, 10000)]
        public int N;
        private double[] data;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(42);
            data = new double[N];
            for (var i = 0; i<N; i++)
            {
                data[i] = random.NextDouble();
            }
        }

        [Benchmark]
        public double Log10()
        {
            double result = 0;
            for (var i = 1; i < N; i++)
            {
                result = Math.Log10(data[i]);
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
                    result = data [i] / data [k];                   
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
                result = Math.Sqrt(data[i]);
            }
            return result;
        }
    }
}
