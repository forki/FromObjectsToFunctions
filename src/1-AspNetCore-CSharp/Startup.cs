namespace Uno
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using System.Threading.Tasks;

    public class Startup
    {
        public void Configure(IApplicationBuilder app) =>
            app.Run(async context => await context.Response.WriteAsync("Hello World from ASP.NET Core"));
    }
}