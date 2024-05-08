using Microsoft.EntityFrameworkCore;
using ProniaMVC.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
opt.UseSqlServer("Server=WIN-0F0TGHD6FSA\\SQLEXPRESS;Database=ProniaMvc;Trusted_connection=true;Integrated security=true;Encrypt=false"

));


var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
