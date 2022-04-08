using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Karnosh.Data;
using System.Text.Json.Serialization;
using Karnosh.Interface;
using Karnosh.Models;
using Karnosh.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<KarnoshContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KarnoshContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
//builder.Services.AddScoped<IBaseRepository<Year>, YearRepository>();
//builder.Services.AddScoped<IBaseRepository<Video>, VideoRepository>();
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
