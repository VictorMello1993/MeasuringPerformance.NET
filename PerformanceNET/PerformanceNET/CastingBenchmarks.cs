using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceNET
{
    public class CastingBenchmarks
    {
        [Params(1000, 10000)]
        public int N;
        public string[] numbers;

        [GlobalSetup]
        public void Setup()
        {
            numbers = new string[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = i.ToString();
            }
        }

        [Benchmark]
        public void CastWithParse()
        {
            for (int i = 0; i < N; i++)
            {
                var num = int.Parse(numbers[i]);
            }
        }

        [Benchmark]
        public void CastWithConvert()
        {
            for (int i = 0; i < N; i++)
            {
                var num = Convert.ToInt32(numbers[i]);
            }
        }

        [Benchmark]
        public void CastWithTryParse()
        {
            for (int i = 0; i < N; i++)
            {
                int.TryParse(numbers[i], out int num);
            }
        }
    }
}
