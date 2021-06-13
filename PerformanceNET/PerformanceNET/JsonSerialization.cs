using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System.Text.Json;

namespace PerformanceNET
{
    public class JsonSerialization
    {
        private string jsonObject = "{\"userId\": 1, \"id\": 1, \"title\": \"Olá mundo\", \"completed\": false }";
        private JsonSerializerOptions jsonSerializerOptions;

        [GlobalSetup]
        public void Setup()
        {
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        [Benchmark]
        public void JsonSerializerDeserializer()
        {
            var obj = System.Text.Json.JsonSerializer.Deserialize<UserTask>(jsonObject);
        }

        [Benchmark]
        public void NewtonsoftJsonDeserializeObjet()
        {
            var obj = JsonConvert.DeserializeObject<UserTask>(jsonObject);
        }
    }
}
