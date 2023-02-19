using System.Text.Json;

namespace BenchmarkSourceGenerator
{
    public class GeneratedSerializer
    {
        //private static BenchmarkJsonSerializerContext context = new BenchmarkJsonSerializerContext();
        private static BenchmarkJsonSerializerContext contextWithOptions = new BenchmarkJsonSerializerContext(
                                    new JsonSerializerOptions(JsonSerializerDefaults.Web));

        public string Convert(string request)
        {
            var requestDto = JsonSerializer.Deserialize(request, BenchmarkJsonSerializerContext.Default.RequestDto);
            var response = Convertor.ToResponse(requestDto);

            var output = JsonSerializer.Serialize(response, BenchmarkJsonSerializerContext.Default.ResponseDto);
            return output;
        }
    }
}
