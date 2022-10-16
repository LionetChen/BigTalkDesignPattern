using Microsoft.EntityFrameworkCore;
using RP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.DataAccess.EFCore.Repositories;
public class UnitOfWork : IUnitOfWork<ApplicationContext>
{
    public UnitOfWork(ApplicationContext context)
    {
        Context = context;
    }

    public ApplicationContext Context { get; }

    public void Save()
    {
        try
        {
            Context.SaveChanges();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception(dbEx.Message, dbEx);
        }
    }

    IGenericRepository<T> IUnitOfWork<ApplicationContext>.GetRepository<T>()
    {
        var type = typeof(T).Name;
        var repositoryType = typeof(GenericRepository<T>);
        return (IGenericRepository<T>)Activator.CreateInstance(repositoryType, Context)!;
    }
}
