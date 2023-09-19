using EP_Jewellery.Areas.Admin.Repository;
using EP_Jewellery.Areas.Admin.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IBrand, BrandService>();

builder.Services.AddDbContext<JeweDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("String")));
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
    endpoints.MapControllerRoute(
        name: "admin",
        pattern: "admin/admin/{controller=Home}/{action}/{id?}",
        defaults: new { area = "Admin", action = "Index" }
    );

    endpoints.MapControllerRoute(
        name: "brand",
        pattern: "admin/brand/{action=Index}/{id?}", // Xóa controller=Home
        defaults: new { area = "Brand", controller = "Home", action = "Index" } // Đặt controller = "Home"
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
