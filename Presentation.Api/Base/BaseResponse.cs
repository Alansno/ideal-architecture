using System.Net;
using System.Text.Json.Serialization;

namespace Presentation.Api.Base;

public class BaseResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }

    public BaseResponse() { } 

    public BaseResponse(object data, string message, bool success)
    {
        Data = data;
        Message = message;
        Success = success;
    }

    public static BaseResponse Ok(object data, string message = "Operation successful")
        => new BaseResponse(data, message, true);

    public static BaseResponse Created(object data, string message = "Model created successfully")
        => new BaseResponse(data, message, true);

    public static BaseResponse Error(string message)
        => new BaseResponse(null, message, false);
}