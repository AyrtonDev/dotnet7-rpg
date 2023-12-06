using Microsoft.VisualBasic;

namespace dotnet_rpg.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;

        public ServiceResponse() { }

        public ServiceResponse(T data)
        {
            Data = data;
        }

        public ServiceResponse(bool success)
        {
            Success = success;
        }

        public ServiceResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
