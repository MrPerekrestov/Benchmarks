using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Benchmarks.Cryptography
{
    public class CryptographyBenchmarks
    {
        private const int N = 10000;
        private readonly byte[] data;

        private readonly SHA256 sha256 = SHA256.Create();
        private readonly MD5 md5 = MD5.Create();

        public CryptographyBenchmarks()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }

        [Benchmark]
        public byte[] Sha256() => sha256.ComputeHash(data);

        [Benchmark]
        public byte[] Md5() => md5.ComputeHash(data);
    }
}
