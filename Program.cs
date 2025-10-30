using Microsoft.EntityFrameworkCore;
using TodoListMVC.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TodoItems}/{action=Index}/{id?}");

// Apply pending EF Core migrations (creates the SQLite database and tables if needed)
using (var scope = app.Services.CreateScope())
{
    try
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        db.Database.Migrate();
    }
    catch (Exception ex)
    {
        // If migrations fail at startup, log to console and continue so app can start for debugging
        Console.WriteLine($"Failed to apply migrations: {ex}");
    }
}

app.Run();
