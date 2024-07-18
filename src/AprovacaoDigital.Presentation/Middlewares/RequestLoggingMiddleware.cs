﻿namespace AprovacaoDigital.Presentation.Middlewares;
public partial class RequestLoggingMiddleware
{
    private readonly RequestDelegate next;

    private readonly ILogger logger;

    public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
    {
        this.next = next;
        this.logger = logger;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        HttpRequest request = httpContext.Request;
        HttpResponse response = httpContext.Response;

        LogRequestStarted(this.logger, LogLevel.Information, request.Method, request.Path);

        try
        {
            await this.next.Invoke(httpContext);

            if (response.StatusCode is >= 200 and <= 299)
            {
                LogRequestFinished(this.logger, LogLevel.Information, request.Method, request.Path, response.StatusCode);
                return;
            }

            if (response.StatusCode >= 500)
            {
                LogRequestFinished(this.logger, LogLevel.Error, request.Method, request.Path, response.StatusCode);
                return;
            }

            LogRequestFinished(this.logger, LogLevel.Warning, request.Method, request.Path, response.StatusCode);
        }
        catch (Exception exception)
        {
            LogRequestException(this.logger, LogLevel.Critical, request.Method, request.Path, exception);
            throw;
        }
    }


    // [LoggerMessage(EventId = 1, Message = "Inbound HTTP {HttpMethod} {RequestPath} started")]
    private static void LogRequestStarted(ILogger logger, LogLevel logLevel, string httpMethod, PathString requestPath)
    {
        logger.Log(logLevel, httpMethod, requestPath);

    }

    //[LoggerMessage(EventId = 2, Message = "Inbound HTTP {HttpMethod} {RequestPath} finished - {StatusCode}")]
    private static void LogRequestFinished(ILogger logger, LogLevel logLevel, string httpMethod, PathString requestPath, int StatusCode)
    {
        logger.Log(logLevel, httpMethod, requestPath);
    }

    //[LoggerMessage(EventId = 3, Message = "Inbound HTTP {HttpMethod} {RequestPath} finished - Unhandled Exception")]
    private static void LogRequestException(ILogger logger, LogLevel logLevel, string httpMethod, PathString requestPath, Exception exception)
    {
        logger.Log(logLevel, httpMethod, requestPath);
    }
}
