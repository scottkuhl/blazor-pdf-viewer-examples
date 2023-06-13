using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Show_or_hide_comment_panel.Data;

using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor().AddHubOptions(o => { o.MaximumReceiveMessageSize = 102400000; });
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSyncfusionBlazor();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MDAxQDMyMzEyZTMxMmUzMjM0TG8xa2pMME1xTHJCczNJWSsvbjdROXZJa0dhNWt4VXZ1QWZVaUFmbjltcz0=");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
