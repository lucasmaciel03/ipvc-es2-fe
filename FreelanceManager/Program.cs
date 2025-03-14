using FreelanceManager.Components;
using DotNetEnv;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

// Load environment variables from .env file
Env.Load();

// Register Syncfusion license
string syncfusionLicenseKey = Environment.GetEnvironmentVariable("SYNCFUSION_LICENSE_KEY") ?? "";
SyncfusionLicenseProvider.RegisterLicense(syncfusionLicenseKey);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register Syncfusion services
builder.Services.AddSyncfusionBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
