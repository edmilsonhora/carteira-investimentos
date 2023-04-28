using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class ProventoRepository : AbstractRepository<Provento>, IProventoRepository
    {
        public ProventoRepository(MyContext contexto) : base(contexto)
        {
        }
    }
}
