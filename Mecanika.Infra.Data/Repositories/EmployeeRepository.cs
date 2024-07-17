using Mecanika.Domain.Interfaces.Repositories;
using Mecanika.Domain.Models;
using Mecanika.Infra.Data.Context.SQL;

namespace Mecanika.Infra.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MecanikaDbContext context) : base(context)
        {

        }
    }
}
