using BenchmarkSourceGenerator.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BenchmarkSourceGenerator
{
    public class NewtonSoftJsonSerializer
    {
        private readonly JsonSerializerSettings options = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public string Convert(string request)
        {
            var requestDto = JsonConvert.DeserializeObject<RequestDto>(request, options);

            var response = Convertor.ToResponse(requestDto);

            string output = JsonConvert.SerializeObject(response, options);
            return output;
        }
    }
}
