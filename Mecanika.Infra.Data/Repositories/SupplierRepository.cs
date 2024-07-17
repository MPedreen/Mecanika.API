using Mecanika.Domain.Interfaces.Repositories;
using Mecanika.Domain.Models;
using Mecanika.Infra.Data.Context.SQL;

namespace Mecanika.Infra.Data.Repositories
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(MecanikaDbContext context) : base(context)
        {

        }
    }
}
