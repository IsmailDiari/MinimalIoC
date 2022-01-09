using Autofac;
using Autofac.Extensions.DependencyInjection;

using MinimalIoC.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Add services to the container.
builder.Services.AddRazorPages();

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterAutoFacModules());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
