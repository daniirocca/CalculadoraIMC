using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AluraBlazorApp.Data;
using CalculadoraIMC.Services;
using System.Reflection.Emit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<ImcCalculatorService>();
builder.Services.AddSingleton<ITranslator, JsonTranslator>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
