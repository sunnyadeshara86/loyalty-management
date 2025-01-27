namespace LoyaltyManagement.Audit.Api.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log Request
            var requestBody = await ReadRequestBody(context.Request);
            _logger.LogInformation("Incoming Request: {Method} {Path} | Body: {Body}",
                context.Request.Method,
                context.Request.Path,
                requestBody);

            // Capture Response
            var originalResponseBodyStream = context.Response.Body;
            using var responseBodyStream = new MemoryStream();
            context.Response.Body = responseBodyStream;

            try
            {
                await _next(context);

                // Log Response
                context.Response.Body.Seek(0, SeekOrigin.Begin);
                var responseBody = await new StreamReader(context.Response.Body).ReadToEndAsync();
                context.Response.Body.Seek(0, SeekOrigin.Begin);

                _logger.LogInformation("Outgoing Response: {StatusCode} | Body: {Body}",
                    context.Response.StatusCode,
                    responseBody);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request.");
                throw;
            }
            finally
            {
                await responseBodyStream.CopyToAsync(originalResponseBodyStream);
            }
        }

        private async Task<string> ReadRequestBody(HttpRequest request)
        {
            if (!request.Body.CanSeek)
            {
                request.EnableBuffering();
            }

            request.Body.Seek(0, SeekOrigin.Begin);
            var body = await new StreamReader(request.Body).ReadToEndAsync();
            request.Body.Seek(0, SeekOrigin.Begin);

            return body;
        }
    }
}
