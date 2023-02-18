using BenchmarkSourceGenerator.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BenchmarkSourceGenerator
{
    public class NewtonSoftJsonConverter
    {
        private static JsonSerializerSettings options = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public string Process(string request)
        {
            var requestDto = JsonConvert.DeserializeObject<RequestDto>(request);

            var response = Convertor.ToResponse(requestDto);

            string output = JsonConvert.SerializeObject(response);
            return output;
        }

        public string ProcessWithOptions(string request)
        {
            var requestDto = JsonConvert.DeserializeObject<RequestDto>(request, options);

            var response = Convertor.ToResponse(requestDto);

            string output = JsonConvert.SerializeObject(response, options);
            return output;
        }
    }
}
