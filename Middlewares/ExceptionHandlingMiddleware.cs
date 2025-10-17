using csharp_todo_api.Exceptions;

namespace csharp_todo_api.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            await HandleExceptionAsync(context, exception);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";

        int statusCode = StatusCodes.Status500InternalServerError;
        string message = "Internal Server Error";

        if (exception is BaseException baseException)
        {
            message = baseException.Message;
            statusCode = baseException.StatusCode;
        }

        var responseError = new
        {
            message = message,
            status = statusCode,
            traceId = context.TraceIdentifier
        };

        context.Response.StatusCode = statusCode;
        return context.Response.WriteAsJsonAsync(responseError);
    }
}
