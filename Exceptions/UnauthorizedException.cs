namespace csharp_todo_api.Exceptions;

public class UnauthorizedException : BaseException
{
    public UnauthorizedException(string message) : base(message, StatusCodes.Status401Unauthorized) { }
}
