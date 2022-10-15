using RP.Domain;
using RP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.DataAccess.EFCore.Repositories;
public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(ApplicationContext context) : base(context)
    {
    }
}
