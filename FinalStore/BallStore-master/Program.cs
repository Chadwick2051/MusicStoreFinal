using SongStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using SongStore.Models.DataAccess;
using MusicStore.Models.DataAccess.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();
builder.Services.AddSession();

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SongContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SongContext")));

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<SongContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository> ();
builder.Services.AddScoped<ISongRepository, SongRepository>();
builder.Services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

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
app.UseAuthentication();
app.UseAuthorization();

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    await ConfigureIdentity.CreateAdminUserAsync(scope.ServiceProvider);
}

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
