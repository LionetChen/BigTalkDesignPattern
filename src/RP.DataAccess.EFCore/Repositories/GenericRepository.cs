using Microsoft.EntityFrameworkCore;
using RP.Domain.Interfaces;
using RP.DataAccess.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RP.DataAccess.EFCore.Repositories;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public ApplicationContext _context = null!;
    public DbSet<T> table = null!;

    public GenericRepository(ApplicationContext context)
    {
        _context = context;
        table = _context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return table.ToList();
    }
    public T? GetById(int id)
    {
        return table.Find(id);
    }
    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }
    public T Insert(T obj)
    {
        table.Add(obj);
        return obj;
    }
    public void Update(T obj)
    {
        table.Attach(obj);
        _context.Entry(obj).State = EntityState.Modified;
    }
    public void Delete(int id)
    {
        T? existing = table.Find(id);
        table.Remove(existing!);
    }
    public void Save()
    {
        _context.SaveChanges();
    }
}