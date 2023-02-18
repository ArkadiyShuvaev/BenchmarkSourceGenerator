using BenchmarkSourceGenerator.Dtos;
using System.Text.Json;

namespace BenchmarkSourceGenerator
{
    public class SourceGeneratorConverter
    {
        //private static BenchmarkJsonSerializerContext context = new BenchmarkJsonSerializerContext();
        private static BenchmarkJsonSerializerContext contextWithOptions = new BenchmarkJsonSerializerContext(
                                    new JsonSerializerOptions(JsonSerializerDefaults.Web));

        public string ProcessWithOptions(string request)
        {
            var requestDto = JsonSerializer.Deserialize(request,
                typeof(RequestDto),
                contextWithOptions) as RequestDto;
            var response = Convertor.ToResponse(requestDto);

            var output = JsonSerializer.Serialize(
                response,
                typeof(ResponseDto),
                contextWithOptions);
            return output;
        }

        public string ProcessCreateNewSerializerWithOptions(string request)
        {
            var requestDto = JsonSerializer.Deserialize(request,
                typeof(RequestDto),
                new BenchmarkJsonSerializerContext(
                                    new JsonSerializerOptions(JsonSerializerDefaults.Web))) as RequestDto;
            var response = Convertor.ToResponse(requestDto);

            var output = JsonSerializer.Serialize(
                response,
                typeof(ResponseDto),
                new BenchmarkJsonSerializerContext(
                                    new JsonSerializerOptions(JsonSerializerDefaults.Web)));
            return output;
        }
    }
}
