using BenchmarkSourceGenerator.Dtos;
using System.Text.Json.Serialization;

namespace BenchmarkSourceGenerator
{
    [JsonSerializable(typeof(RequestDto))]
    [JsonSerializable(typeof(ResponseDto))]
    [JsonSerializable(typeof(PayloadDto))]
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
    public partial class BenchmarkJsonSerializerContext : JsonSerializerContext
    {
    }
}
