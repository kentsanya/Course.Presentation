using Course.Presentation.Logic.Interfaces;
using Course.Presentation.Logic.Logger;
using Course.Presentation.Logic.Services;
using Course.Presentation.Middleware;

namespace Course.Presentation
{
    public class Program
    {
        public delegate RequestDelegate RequestDelegate(HttpContext context);

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession();
            builder.Services.AddScoped<ICounter, RandomCounter>();
            builder.Services.AddScoped<CounterService>();
            builder.Logging.AddFile(Path.Combine(Directory.GetCurrentDirectory(),"2402log.txt"));
            var app = builder.Build();

            app.UseDefaultFiles();


            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseMiddleware<CounterMiddleware>();

            app.Run(async (context) => 
            {
                if(context.Session.Keys.Contains("counter"))
                    await context.Response.WriteAsync($"Localiztion {context.Session.GetInt32("counter")}");
                else
                    await context.Response.WriteAsync($"Session Empty");
            });
            app.Run();
        }
    }
}