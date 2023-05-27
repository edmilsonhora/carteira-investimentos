using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DomainModel;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class VendaRepository : AbstractRepository<Venda>, IVendaRepository
    {
        public VendaRepository(MyContext contexto) : base(contexto)
        {
        }
    }
}
