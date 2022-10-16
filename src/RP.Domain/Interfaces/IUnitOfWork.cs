using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Domain.Interfaces;
public interface IUnitOfWork<TContext> where TContext : class
{
    public IGenericRepository<T> GetRepository<T>() where T : class;
    public TContext Context { get; }
    public void Save();
}
