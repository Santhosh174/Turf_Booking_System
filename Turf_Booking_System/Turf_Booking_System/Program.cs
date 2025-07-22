using Turf_Booking_System.Web.Components;
using Turf_Booking_System.Common.DependencyInjection.Interface;
using Turf_Booking_System.Common.DependencyInjection.Services;
using Turf_Booking_System.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IDataList<User>, Service<User>>();
builder.Services.AddSingleton<IDataList<Turf>, Service<Turf>>();
builder.Services.AddSingleton<IDataList<Bookings>, Service<Bookings>>();

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
