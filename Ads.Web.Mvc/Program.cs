﻿using Ads.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(o =>
{
	// appSettings.json içerisindeki Default baðlantý metnini almayý saðlar.
	string connectionString = builder.Configuration.GetConnectionString("Default");
	o.UseSqlServer(connectionString);
});


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
	// Veritabaný servisine eriþim saðlar.
	var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
	// Veritabanýný sil
	//context.Database.EnsureDeleted();
	// Veritabanýný oluþturur
	context.Database.EnsureCreated();
}


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

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Category}/{action=Index}/{page}/{id}");

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Advert}/{action=Detail}/{id}");

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Page}/{action=Detail}/{id}");


app.MapControllerRoute(
		name: "Admin",
		pattern: "{area:exists}/{controller}/{action}"
	);

app.Run();
