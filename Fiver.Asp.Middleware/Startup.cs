using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Fiver.Asp.HelloMiddleware;

namespace Fiver.Asp.Middleware
{
    public class Startup
    {
        public Startup(
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            IConfiguration config)
        {
        }

        public void ConfigureServices(
            IServiceCollection services)
        {
        }

        //public void Configure(
        //    IApplicationBuilder app, 
        //    IHostingEnvironment env)
        //{
        //    app.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Hello World! (Run)");
        //    });
        //}

        //public void Configure(
        //    IApplicationBuilder app,
        //    IHostingEnvironment env)
        //{
        //    app.RunHelloWorld();
        //}

        //public void Configure(
        //    IApplicationBuilder app,
        //    IHostingEnvironment env)
        //{
        //    app.UseHelloWorld();
        //    app.RunHelloWorld();
        //}

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env)
        {
            app.UseHelloWorld();
            app.UseHelloWorldInClass();
            app.RunHelloWorld();
        }
    }
}
