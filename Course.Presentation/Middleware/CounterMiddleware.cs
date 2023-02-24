using Course.Presentation.Logic.Interfaces;
using Course.Presentation.Logic.Services;

namespace Course.Presentation.Middleware
{
    public class CounterMiddleware
    {
        RequestDelegate next;
        int countrequest = 0;
        public CounterMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context, ICounter counter, CounterService counterService) 
        {

            countrequest++;
            context.Session.SetInt32("counter", countrequest);
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync($"Request number {countrequest}, Counter {counter.Value}, ServicesCount {counterService._counter.Value}");
            await next.Invoke(context);
        }
    }
}
