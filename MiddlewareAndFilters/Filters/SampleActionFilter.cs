using Microsoft.AspNetCore.Mvc.Filters;

namespace MiddlewareAndFilters.Filters
{
    public class SampleActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<SampleActionFilter> _logger;

        public SampleActionFilter(ILogger<SampleActionFilter> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("SyncFilter - BEFORE");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("SyncFilter - AFTER");
        }
    }
}