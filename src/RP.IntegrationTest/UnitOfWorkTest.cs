using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RP.DataAccess.EFCore;
using RP.Domain;
using RP.Domain.Interfaces;
using System;

namespace RP.IntegrationTest;
[TestClass]
public class UnitOfWorkTest
{
    [TestMethod]
    public void MyTestMethod()
    {
        var application = new WebApplicationFactory<Program>()
        .WithWebHostBuilder(builder =>
        {
            // ... Configure test services
        });

        var client = application.CreateClient();
        using var scope = application.Services.CreateScope();
        using var db = scope.ServiceProvider.GetRequiredService<ApplicationContext>();

        IUnitOfWork<ApplicationContext> uow = scope.ServiceProvider.GetRequiredService<IUnitOfWork<ApplicationContext>>();
        IGenericRepository<Employee> employeeUow = uow.GetRepository<Employee>();
        IGenericRepository<Department> departmentUow = uow.GetRepository<Department>();

        Employee sally = employeeUow.Insert(new Employee() { Gender = "Female", Name = "Sally" });        
        //Assert.AreEqual(5, sally.Id);
        //Assert.AreEqual("Sally", employeeUow.GetById(5)!.Name);

        Department departmentFailToAdd = departmentUow.Insert(new Department() { Id = 1, Name = "Duplicate" });
        departmentUow.Insert(departmentFailToAdd);

        var ex = Assert.ThrowsException<Exception>(() => uow.Save());
        Console.WriteLine(ex.Message);

        var er = scope.ServiceProvider.GetRequiredService<IEmployeeRepository>();
        Assert.IsNull(er.GetById(5));
    }
}