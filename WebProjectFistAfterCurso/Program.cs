using Microsoft.EntityFrameworkCore;
using WebProjectFistAfterCurso.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>(options => options.UseSqlServer("workstation id=BD-DB-Rafael.mssql.somee.com;packet size=4096;user id=RafaeldosReis19_SQLLogin_1;pwd=pm6e3di2e5;data source=BD-DB-Rafael.mssql.somee.com;persist security info=False;initial catalog=BD-DB-Rafael"));

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
