using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DomainModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class AtivoRepository : AbstractRepository<Ativo>, IAtivoRepository
    {
        private readonly MyContext _contexto;

        public AtivoRepository(MyContext contexto) : base(contexto)
        {
            this._contexto = contexto;
        }

        public bool JahExisteNaBaseDeDados(Ativo ativo)
        {
            return this._contexto.Ativos.Any(p => p.Ticker.ToLower() == ativo.Ticker.ToLower() && p.Id != ativo.Id && p.EhAtivo);
        }

        public new Ativo ObterPor(int id)
        {
            return _contexto.Ativos.Include(p => p.Proventos)
                                   .Include(p => p.Aportes)
                                   .Include(p => p.Vendas)
                                   .FirstOrDefault(p => p.Id == id);
        }

        public decimal ObterSaldoTotalInvestido()
        {
            return _contexto.Ativos.Where(p => p.EhAtivo).Sum(p => p.SaldoAtual);
        }

        public new List<Ativo> ObterTodos()
        {
            return _contexto.Ativos.Where(p => p.EhAtivo).AsNoTracking().ToList();
        }
    }
}
