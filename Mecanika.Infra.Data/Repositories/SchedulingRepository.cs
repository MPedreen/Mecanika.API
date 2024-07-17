using Mecanika.Domain.Interfaces.Repositories;
using Mecanika.Domain.Models;
using Mecanika.Infra.Data.Context.SQL;

namespace Mecanika.Infra.Data.Repositories
{
    public class SchedulingRepository : Repository<Scheduling>, ISchedulingRepository
    {
        public SchedulingRepository(MecanikaDbContext context) : base(context)
        {

        }
    }
}
