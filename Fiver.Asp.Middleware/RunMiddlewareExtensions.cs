using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Fiver.Asp.Middleware
{
    public static class RunMiddlewareExtensions
    {
        public static void RunHelloWorld(this IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World! (Run in Extension Method)");
            });
        }
    }
}
