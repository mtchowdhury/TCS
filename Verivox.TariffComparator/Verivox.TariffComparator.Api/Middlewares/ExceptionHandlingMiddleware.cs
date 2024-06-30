
using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Verivox.TariffComparator.Api.Middlewares;

public class ExceptionHandlingMiddleware : IMiddleware
{
    private readonly ILogger _logger;
    public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            HandleExceptionAsync(context, e);
        }
    }
    private void HandleExceptionAsync(HttpContext context, Exception exception)
    {
        NoHandlerForException(context, exception);
    }
    private void NoHandlerForException(HttpContext context, Exception exception)
    {
        var strackTrace = new StackTrace(exception);
        _logger.LogError(strackTrace.GetFrame(0).GetMethod().DeclaringType + " " + strackTrace.GetFrame(0).GetMethod().Name +
                ": Something went wrong: " + exception.Message);
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response
            .WriteAsJsonAsync(new
            {
                Message = "An unexpected error occurred.",
                Exception = Environment.IsDevelopment() ? exception : null
            })
            .GetAwaiter()
            .GetResult();
    }
    private IWebHostEnvironment Environment { get; init; }
}

