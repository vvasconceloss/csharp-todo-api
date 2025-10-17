namespace csharp_todo_api.Exceptions;

public class NotFoundException : BaseException
{
    public NotFoundException(string message) : base(message, StatusCodes.Status404NotFound) { }
}
