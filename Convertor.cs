using BenchmarkSourceGenerator.Dtos;

namespace BenchmarkSourceGenerator
{
    public static class Convertor
    {
        public static ResponseDto ToResponse(RequestDto requestDto)
        {
            return new ResponseDto
            {
                ResponseBool = requestDto.RequestBool,
                ResponseDate = requestDto.RequestDate,
                ResponseGuid = requestDto.RequestGuid,
                ResponseNumber = requestDto.RequestNumber,
                ResponseType = requestDto.RequestType,
                ResponsePayload = new PayloadDto
                {
                    Number = requestDto.RequestPayload.Number,
                    DateTime = requestDto.RequestPayload.DateTime,
                    PayloadGuid = requestDto.RequestPayload.PayloadGuid,
                    PayloadBool = requestDto.RequestPayload.PayloadBool,
                    PayloadString = requestDto.RequestPayload.PayloadString
                }
            };
        }
    }
}