

using Microsoft.EntityFrameworkCore;
using PurpleBuzz.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options=> options.UseSqlServer("server=DESKTOP-AKQ170U;database=PurpleBuzzDB;Trusted_connection=true;Integrated security=true;Encrypt=false"));
var app = builder.Build();



app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles();
app.Run();
