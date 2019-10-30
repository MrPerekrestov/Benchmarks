using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmarks.Sorting
{
    public class SortingBenchmarks
    {
        private int[] dataForSort;        
        private int[] dataForLinqSort;
        [Params(1000, 10000)]
        public int N;
        [GlobalSetup]
        public void Setup()
        {
            dataForSort = new int[N];
            var random = new Random();
            for (var i = 0; i < N; i++)
            {
                dataForSort[i] = random.Next(int.MinValue, int.MaxValue);
            }
            dataForLinqSort = new int[N];            
            for (var i = 0; i < N; i++)
            {
                dataForLinqSort[i] = random.Next(int.MinValue, int.MaxValue);
            }

        }
        [Benchmark]
        public void Sort() => Array.Sort(dataForSort);

        [Benchmark]
        public int[] SortLinq() => dataForLinqSort.OrderBy(a => a).ToArray();
    }
}
