using LibraryBLL;
using LibraryContracts;
using LibraryDAL.DataContext;
using LibraryDAL.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LibraryContext>(mybuilder => mybuilder.UseSqlServer(builder.Configuration.GetConnectionString("myConecction"), b => b.MigrationsAssembly("LibraryDAL")));

builder.Services.AddScoped<ILibroService, LibroService>();
builder.Services.AddScoped<IGenericRepository<Libro>>();



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
