namespace MiddlewareAndFilters.Middleware
{
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<SampleMiddleware> _logger;

        public SampleMiddleware(RequestDelegate next, ILogger<SampleMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation("Middleware - BEFORE");
            await _next.Invoke(context);
            _logger.LogInformation("Middleware - AFTER");
        }
    }

    public static class SampleMiddlewareExtensions
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SampleMiddleware>();
        }
    }
}