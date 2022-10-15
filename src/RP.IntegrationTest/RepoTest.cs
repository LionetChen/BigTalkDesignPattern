using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using RP.DataAccess.EFCore;
using RP.Domain.Interfaces;
using RP.Web;

namespace RP.IntegrationTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void DirectAccessWithoutRepo()
    {
        var application = new WebApplicationFactory<Program>()
        .WithWebHostBuilder(builder =>
        {
            // ... Configure test services
        });

        var client = application.CreateClient();
        using var scope = application.Services.CreateScope();
        using var db = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
        
        Assert.AreEqual(db.Departments.OrderBy(x => x.Id).First().Name, "HR");
    }

    [TestMethod]
    public void DirectAccessWithRepo()
    {
        var application = new WebApplicationFactory<Program>()
        .WithWebHostBuilder(builder =>
        {
            // ... Configure test services
        });

        var client = application.CreateClient();
        using var scope = application.Services.CreateScope();
        var er = scope.ServiceProvider.GetRequiredService<IDepartmentRepository>();

        Assert.AreEqual("HR", er.GetById(1)?.Name);
    }
}