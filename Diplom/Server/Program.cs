using Diplom.Application;
using Diplom.Application.Abstracts;
using Diplom.Mapping;
using Diplom.Persistence;
using Diplom.Server;
using Domain.Infrastructure.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplication();
builder.Services.ConfigureRepositories();

builder.Services.AddMediatR(typeof(ApplicationAbstractionAssembly), typeof(ApplicationAssembly));
builder.Services.AddAutoMapper(typeof(AutoMapperAssembly));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
