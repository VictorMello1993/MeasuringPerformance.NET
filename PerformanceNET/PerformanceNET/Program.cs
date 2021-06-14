using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<Md5VsSha256>();
            //var summary = BenchmarkRunner.Run<JsonSerialization>();
            var summary = BenchmarkRunner.Run<ForVsForEachOnArrayVsIEnumerable>();
            //var summary = BenchmarkRunner.Run<StringComparisonBenchmarks>();
            //var summary = BenchmarkRunner.Run<StringConcatVsStringFormatVsInterpolationVsStringBuilder>();
            //var summary = BenchmarkRunner.Run<CastingBenchmarks>();
        }
    }
}
