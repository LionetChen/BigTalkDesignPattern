using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Domain.Interfaces;
public interface IEmployeeRepository : IGenericRepository<Employee>
{
    public IEnumerable<Employee> GetByGender(string gender);
}
