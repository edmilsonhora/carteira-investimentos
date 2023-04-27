using ESH_CalculadoraPrecoMedio.DataAccess.Contexts;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.DataAccess.Repositories
{
    internal class AtivoRepository : AbstractRepository<Ativo>, IAtivoRepository
    {
        public AtivoRepository(MyContext contexto) : base(contexto)
        {

        }
    }
}
