using Microsoft.EntityFrameworkCore;
using RP.Domain;

namespace RP.DataAccess.EFCore;
public class ApplicationContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
              .HasData(
               new Department { Id = 1, Name = "HR" },
               new Department { Id = 2, Name = "Admin" },
               new Department { Id = 3, Name = "Production" });
    }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public virtual DbSet<Employee> Developers { get; set; } = null!;
    public virtual DbSet<Department> Departments { get; set; } = null!;
}