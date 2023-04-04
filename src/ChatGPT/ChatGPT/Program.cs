using ElectronNET.API;
using ElectronNET.API.Entities;

using OpenAI.Net;

namespace ChatGPT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            builder.Services.AddOpenAIServices(o =>
            {
                o.ApiKey = builder.Configuration["OpenAI:ApiKey"];
            });

            builder.Services.AddElectron();
            builder.WebHost.UseElectron(args);

            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}