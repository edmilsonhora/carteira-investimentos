using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class VendaRepository : AbstractRepository<Venda>, IVendaRepository
    {
        public VendaRepository(MyContext contexto) : base(contexto)
        {
        }
    }
}
