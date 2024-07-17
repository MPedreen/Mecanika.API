﻿using Mecanika.Domain.Interfaces.Repositories;
using Mecanika.Domain.Models;
using Mecanika.Infra.Data.Context.SQL;

namespace Mecanika.Infra.Data.Repositories
{
    public class EstablishmentRepository : Repository<Establishment>, IEstablishmentRepository
    {
        public EstablishmentRepository(MecanikaDbContext context) : base(context)
        {

        }
    }
}
