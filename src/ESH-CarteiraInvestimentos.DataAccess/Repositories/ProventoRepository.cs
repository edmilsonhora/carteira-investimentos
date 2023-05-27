using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DomainModel;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class ProventoRepository : AbstractRepository<Provento>, IProventoRepository
    {
        public ProventoRepository(MyContext contexto) : base(contexto)
        {
        }
    }
}
