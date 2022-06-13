using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VendasWebMvc.Data;
using VendasWebMvc.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<VendasWebMvcContext>(options =>
    options.UseMySql("server=localhost;initial catalog=_VENDAS_WEB_MVC;uid=Daniel;pwd=ironmaidenF6%", ServerVersion.Parse("8.0.29-mysql")));

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();

static void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env, SeedingService seed)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        seed.Seed();
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }
}


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
