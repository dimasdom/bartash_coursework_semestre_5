using Core.Interfaces;
using Core.Services;
using Infrastracture.Core.Interfaces.IRepositories;
using Infrastracture.DataBase.ApplicationDbContext;
using Infrastracture.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Додаємо контролери та представлення до сервісів ASP.NET Core
builder.Services.AddControllersWithViews();

// Конфігурація та підключення до бази даних SQLite з використанням Entity Framework Core
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=Bartash.db");
});

// Додаємо репозиторії та сервіси до контейнера залежностей
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IAutoBaseRepository, AutoBaseRepository>();
builder.Services.AddTransient<IFuelRepository, FuelRepository>();
builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAutoBaseService, AutoBaseService>();
builder.Services.AddTransient<IFuelService, FuelService>();
builder.Services.AddTransient<ISupplierService, SupplierService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();

// Конфігурація додатку та HTTP request pipeline
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // Якщо додаток працює не в режимі розробки, налаштовуємо обробник помилок
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Налаштовуємо маршрутизацію контролерів
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Запускаємо додаток
app.Run();