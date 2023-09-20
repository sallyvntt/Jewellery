<<<<<<< HEAD
﻿using EP_Jewellery.Areas.Admin.Repository;
using EP_Jewellery.Areas.Admin.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IBrand, BrandService>();
builder.Services.AddScoped<ICat, CatService>();


builder.Services.AddDbContext<JeweDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("String")));
=======
﻿var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
>>>>>>> parent of 21ebbc5 (1)
builder.Services.AddControllersWithViews();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Thêm dịch vụ Razor Pages
builder.Services.AddRazorPages();

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

app.UseEndpoints(endpoints =>
{

    endpoints.MapAreaControllerRoute(
        name: "admin",
        areaName: "Admin",
        pattern: "admin/{controller=Admin}/{action=Index}/{id?}"
    );
    // Thêm route mặc định cho "/admin" và chuyển hướng đến "admin/admin/"
    endpoints.MapControllerRoute(
        name: "admin-default",
        pattern: "admin",
        defaults: new { area = "Admin", controller = "Home", action = "Index" }
    );


    // Route cho khu vực "Brand"
    endpoints.MapAreaControllerRoute(
        name: "brand",
        areaName: "Brand",
        pattern: "admin/brand/{controller=Brand}/{action=Index}/{id?}"
    );// Route cho khu vực "Cates"
    endpoints.MapAreaControllerRoute(
        name: "cate",
        areaName: "Cate",
        pattern: "admin/cate/{controller=Cate}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapRazorPages();
});





app.UseCors("AllowAll");
app.MapControllers();
app.UseRouting();

app.Run();
