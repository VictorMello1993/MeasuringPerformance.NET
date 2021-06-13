using BenchmarkDotNet.Attributes;

namespace PerformanceNET
{
    public class StringComparisonBenchmarks
    {
        public string nameLowerCase = "victor";
        public string nameUpperCase = "VICTOR";

        [Benchmark]
        public bool EqualityWithToLower()
        {            
            return nameLowerCase == nameUpperCase.ToLower();
        }

        [Benchmark]
        public bool EqualityWithToUpper()
        {
            return nameLowerCase.ToUpper() == nameUpperCase;
        }

        [Benchmark]
        public bool CompareWithIgnoreCase()
        {
            return string.Compare(nameLowerCase, nameUpperCase, System.StringComparison.OrdinalIgnoreCase) == 0;
        }

        [Benchmark]
        public bool EqualsIgnoreCase()
        {
            return nameLowerCase.Equals(nameUpperCase, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}
