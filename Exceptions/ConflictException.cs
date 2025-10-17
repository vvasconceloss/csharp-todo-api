namespace csharp_todo_api.Exceptions;

public class ConflictException : BaseException
{
    public ConflictException(string message) : base(message, StatusCodes.Status409Conflict) { }
}
