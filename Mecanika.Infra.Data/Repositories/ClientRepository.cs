using Mecanika.Domain.Interfaces.Repositories;
using Mecanika.Infra.Data.Context.SQL;

namespace Mecanika.Infra.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public ClientRepository(MecanikaDbContext context)
        {

        }
    }
}
