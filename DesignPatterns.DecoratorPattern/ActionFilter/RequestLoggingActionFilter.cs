using Microsoft.AspNetCore.Mvc.Filters;

namespace DesignPatterns.DecoratorPattern.ActionFilter
{
    public class RequestLoggingActionFilter : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // do something
            await next();
            // do something
        }
    }
}
