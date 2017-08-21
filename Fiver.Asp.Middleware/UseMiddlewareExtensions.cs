using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Fiver.Asp.Middleware
{
    public static class UseMiddlewareExtensions
    {
        public static IApplicationBuilder UseHelloWorld(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello World! (Use)\n");
                await next();
            });
        }

        public static IApplicationBuilder UseHelloWorldInClass(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloWorldMiddleware>();
        }
    }

    public class HelloWorldMiddleware
    {
        private readonly RequestDelegate next;

        public HelloWorldMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("Hello World! (Use in Class)\n");
            await this.next(context);
        }
    }
}
