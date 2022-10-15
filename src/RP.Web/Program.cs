using Microsoft.EntityFrameworkCore;
using RP.DataAccess.EFCore;
using RP.DataAccess.EFCore.Repositories;
using RP.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationContext>(
    options =>
    {
        options.UseSqlite(@"Data Source=AppDb.sqlite;",
        sqliteOptions =>
        {
            sqliteOptions.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName);
        }
    );
});

#region Repositories
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IDepartmentRepository, DepartmentRepository>();
#endregion

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

public partial class Program { }