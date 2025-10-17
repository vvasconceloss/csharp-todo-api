namespace csharp_todo_api.Exceptions;

public class BadRequestException : BaseException
{
    public BadRequestException(string message) : base(message, StatusCodes.Status400BadRequest) { }
}
