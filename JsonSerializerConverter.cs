using BenchmarkSourceGenerator.Dtos;
using System;
using System.Text.Json;

namespace BenchmarkSourceGenerator
{
    public class JsonSerializerConverter
    {
        private BenchmarkJsonSerializerContext context = new BenchmarkJsonSerializerContext();
        private BenchmarkJsonSerializerContext contextWithOptions = new BenchmarkJsonSerializerContext(
                                    new JsonSerializerOptions(JsonSerializerDefaults.Web));

        private JsonSerializerOptions options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        //public string ProcessWithOptions(string request)
        //{     
        //    var requestDto = JsonSerializer.Deserialize(request,
        //        typeof(RequestDto),
        //        contextWithOptions) as RequestDto;
        //    var response = Convertor.ToResponse(requestDto);

        //    var output = JsonSerializer.Serialize(
        //        response,
        //        typeof(ResponseDto),
        //        contextWithOptions);
        //    return output;
        //}

        public string ProcessWithOptions(string request)
        {
            var requestDto = JsonSerializer.Deserialize<RequestDto>(request, options);
            var response = Convertor.ToResponse(requestDto);

            var output = JsonSerializer.Serialize(response, options);
            return output;
        }
    }
}
