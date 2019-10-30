using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmarks.Sorting
{
    public class SortingBenchmarks
    {
        private int[] _dataForSort;        
        private int[] _dataForLinqSort;
        private List<int> _dataForListSort;
        [Params(1000, 10000)]
        public int N;

        [GlobalSetup]        
        public void Setup()
        {
            _dataForSort = new int[N];
            var random = new Random();

            for (var i = 0; i < N; i++)
            {
                _dataForSort[i] = random.Next(int.MinValue, int.MaxValue);
            }

            _dataForLinqSort = new int[N];            
            for (var i = 0; i < N; i++)
            {
                _dataForLinqSort[i] = random.Next(int.MinValue, int.MaxValue);
            }

            _dataForListSort = new List<int>();
            for (var i = 0; i < N; i++)
            {
                _dataForListSort.Add(random.Next(int.MinValue, int.MaxValue));
            }

        }
        [Benchmark]
        public void ArraySort() => Array.Sort(_dataForSort);      

        [Benchmark]
        public void ListSort() => _dataForListSort.Sort();

        [Benchmark]        
        public int[] OrderBy() => _dataForLinqSort.OrderBy(a => a).ToArray();
    }
}
