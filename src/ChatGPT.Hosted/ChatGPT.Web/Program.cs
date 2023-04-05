using OpenAI.Net;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var apiKey = builder.Configuration["OpenAI:ApiKey"];

services.AddRazorPages();
services.AddServerSideBlazor();
services.AddOpenAIServices(o =>
{
    o.ApiKey = apiKey;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment()) app.UseExceptionHandler("/Error");

app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();