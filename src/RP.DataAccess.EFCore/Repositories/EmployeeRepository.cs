using RP.Domain;
using RP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.DataAccess.EFCore.Repositories;
public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(ApplicationContext context) : base(context)
    {
    }

    public IEnumerable<Employee> GetByGender(string gender)
    {
        return Find(x => x.Gender == gender);
    }
}
