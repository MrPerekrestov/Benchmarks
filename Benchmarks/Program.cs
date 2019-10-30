using BenchmarkDotNet.Running;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<SortingBenchmarks>();
            var summaryAll = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
