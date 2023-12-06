using Core.Interfaces;
using Core.Services;
using Infrastracture.Core.Interfaces.IRepositories;
using Infrastracture.DataBase.ApplicationDbContext;
using Infrastracture.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=Bartash.db");
});
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IAutoBaseRepository, AutoBaseRepository>();
builder.Services.AddTransient<IFuelRepository, FuelRepository>();
builder.Services.AddTransient<ISupplierRepository,SupplierRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAutoBaseService, AutoBaseService>();
builder.Services.AddTransient<IFuelService, FuelService>();
builder.Services.AddTransient<ISupplierService, SupplierService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
//builder.AddApplicationServices();
var app = builder.Build();

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
