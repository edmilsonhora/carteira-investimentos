using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.DomainModel
{
    public interface IRepository
    {
        IAtivoRepository Ativos { get; }
        IAporteRepository Aportes { get; }
        IProventoRepository Proventos { get; }

        void SaveChanges();
        void Rollback();
    }
}
