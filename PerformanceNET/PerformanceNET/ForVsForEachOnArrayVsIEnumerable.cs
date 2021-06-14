using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceNET
{
    public class ForVsForEachOnArrayVsIEnumerable
    {
        [Params(1000, 10000)]
        public int N;

        public int[] array;
        public IEnumerable<int> enumerable;
        public Random random;
        public List<int> list;

        [GlobalSetup]
        public void Setup()
        {
            array = new int[N];
            list = new List<int>();

            enumerable = list;

            random = new Random();

            for (int i = 0; i < N; i++)
            {
                var number = random.Next(0, 100);

                array[i] = number;
                list.Add(number);
            }
        }

        [Benchmark]
        public void ForArray()
        {
            var sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += array[i];
            }
        }

        [Benchmark]
        public void ForEachArray()
        {
            var sum = 0;

            foreach (var number in array)
            {
                sum += number;
            }
        }

        [Benchmark]
        public void ForEachIEnumerable()
        {
            var sum = 0;

            foreach (var number in enumerable)
            {
                sum += number;
            }
        }

        [Benchmark]
        public void ForEachList()
        {
            var sum = 0;

            foreach (var number in list)
            {
                sum += number;
            }
        }

        [Benchmark]
        public void ForEachLinqList()
        {
            var sum = 0;
            list.ForEach((num) =>
            {
                sum += num;
            });
        }

        [Benchmark]
        public void ForList()
        {
            var sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += list[i];
            }
        }

        [Benchmark]
        public void ForEnumerable()
        {
            var sum = 0;
            var enumerator = enumerable.GetEnumerator();

            for (; enumerator.MoveNext();)
            {
                sum += enumerator.Current;
            }
        }
    }
}
