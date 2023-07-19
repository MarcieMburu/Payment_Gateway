
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Payment_Gateway;
using Payment_Gateway.Models;

var builder = WebApplication.CreateBuilder(args);
IServiceCollection serviceCollection = builder.Services.AddDbContext<Payment_GatewayContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PaymentGateway") ?? throw new InvalidOperationException("Connection string 'Payment_GatewayContext' not found.")));

IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Sets the base path where the appsettings.json is located
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true) // Loads appsettings.json
            .Build();

string connectionString = configuration.GetConnectionString("PaymentGateway");

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//DI for DbContext
builder.Services.AddDbContext<Payment_GatewayContext>();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

