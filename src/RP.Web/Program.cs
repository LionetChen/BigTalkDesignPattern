using Microsoft.EntityFrameworkCore;
using RP.DataAccess.EFCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationContext>(options=>options.UseSqlite(@"Data Source=AppDb.sqlite;"));

var app = builder.Build();

// Auto migrate the database
using (var Scope = app.Services.CreateScope())
{
    using var context = Scope.ServiceProvider.GetRequiredService<ApplicationContext>(); 
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
