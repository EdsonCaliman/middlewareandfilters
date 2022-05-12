using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddlewareAndFilters.Filters
{
    public class SampleAsyncActionFilter : IAsyncActionFilter
    {
        private readonly ILogger<SampleAsyncActionFilter> _logger;

        public SampleAsyncActionFilter(ILogger<SampleAsyncActionFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("AsyncFilter - BEFORE");
            await next();
            _logger.LogInformation("AsyncFilter - AFTER");
        }
    }
}