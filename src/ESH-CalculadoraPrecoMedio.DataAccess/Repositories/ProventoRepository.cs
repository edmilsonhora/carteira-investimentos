using ESH_CalculadoraPrecoMedio.DataAccess.Contexts;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.DataAccess.Repositories
{
    internal class ProventoRepository : AbstractRepository<Provento>, IProventoRepository
    {
        public ProventoRepository(MyContext contexto) : base(contexto)
        {
        }
    }
}
