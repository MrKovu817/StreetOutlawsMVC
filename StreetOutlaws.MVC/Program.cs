using Microsoft.EntityFrameworkCore;
using StreetOutlaws.Data.Context;
using AutoMapper;
using StreetOutlaws.Services.CarServices;
using StreetOutlaws.Services.Configurations;
using StreetOutlaws.Services.DriverServices;
using StreetOutlaws.Services.TeamServices;
using StreetOutlaws.Services.TrackServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(opt=>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper((typeof(MappingConfigurations)));
builder.Services.AddScoped<ICarService,CarService>();
builder.Services.AddScoped<IDriverService,DriverService>();
builder.Services.AddScoped<ITeamService,TeamService>();
builder.Services.AddScoped<ITrackService,TrackService>();

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
