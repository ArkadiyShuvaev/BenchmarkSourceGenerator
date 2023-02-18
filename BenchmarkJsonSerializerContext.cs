using BenchmarkSourceGenerator.Dtos;
using System.Text.Json.Serialization;

namespace BenchmarkSourceGenerator
{
    [JsonSerializable(typeof(RequestDto))]
    [JsonSerializable(typeof(ResponseDto))]
    [JsonSerializable(typeof(PayloadDto))]
    public partial class BenchmarkJsonSerializerContext : JsonSerializerContext
    {
    }
}
