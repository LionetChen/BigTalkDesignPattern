using Microsoft.EntityFrameworkCore;
using RP.Domain;

namespace RP.DataAccess.EFCore;
public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }
    public virtual DbSet<Employee> Developers { get; set; } = null!;
}