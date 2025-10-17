namespace csharp_todo_api.Exceptions;

public class BaseException : Exception
{
    public int StatusCode { get; }

    public BaseException(string message, int statusCode = StatusCodes.Status400BadRequest) : base(message)
    {
        StatusCode = statusCode;
    }
}
