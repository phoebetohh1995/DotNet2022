using Microsoft.EntityFrameworkCore;
using ProductApplicationAssignment.Models;
using ProductApplicationAssignment.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string strCon = builder.Configuration.GetConnectionString("myCon");

builder.Services.AddDbContext<ShopContext>(opts =>
{
    opts.UseSqlServer(strCon);
});

builder.Services.AddScoped<IRepo<int, Product>, ProductRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
