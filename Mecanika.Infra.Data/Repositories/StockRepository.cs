using Mecanika.Domain.Interfaces.Repositories;
using Mecanika.Domain.Models;
using Mecanika.Infra.Data.Context.SQL;

namespace Mecanika.Infra.Data.Repositories
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        public StockRepository(MecanikaDbContext context) : base(context)
        {

        }
    }
}
