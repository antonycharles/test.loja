using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Loja.Web.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.AddDataBase();
builder.Services.AddDependencyInjectionConfiguration();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

app.AddMigration();
app.SeedData();

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
