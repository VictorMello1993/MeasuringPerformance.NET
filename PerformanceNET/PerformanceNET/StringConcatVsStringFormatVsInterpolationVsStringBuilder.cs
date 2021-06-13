using BenchmarkDotNet.Attributes;
using System.Text;

namespace PerformanceNET
{
    public class StringConcatVsStringFormatVsInterpolationVsStringBuilder
    {
        public string cumprimento = "Ola";
        public string nome = "Victor";

        [Benchmark]
        public void Format()
        {
            var message = string.Format("{0}, {1}!", cumprimento, nome);
        }

        [Benchmark]
        public void Concat()
        {
            var message = cumprimento + ", " + nome + "!";
        }

        [Benchmark]
        public void StringInterpolation()
        {
            var message = $"{cumprimento}, {nome}!";
        }

        [Benchmark]
        public void StringBuilderTest()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(cumprimento);
            stringBuilder.Append(", ");            
            stringBuilder.Append(nome);            
            stringBuilder.Append("!");

            var message = stringBuilder.ToString();
        }
    }
}
