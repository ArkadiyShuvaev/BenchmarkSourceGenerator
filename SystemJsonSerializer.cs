using BenchmarkSourceGenerator.Dtos;
using System.Text.Json;

namespace BenchmarkSourceGenerator
{
    public class SystemJsonSerializer
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        public string Convert(string request)
        {
            var requestDto = JsonSerializer.Deserialize<RequestDto>(request, options);
            var response = Convertor.ToResponse(requestDto);

            var output = JsonSerializer.Serialize(response, options);
            return output;
        }
    }
}
