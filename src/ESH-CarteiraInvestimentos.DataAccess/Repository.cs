using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DataAccess.Repositories;
using ESH_CarteiraInvestimentos.DataAccess.RestApis;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DataAccess
{
    public class Repository : IRepository
    {
        private MyContext _context;
        private CotacaoApi _cotacaoApi;
        public Repository()
        {
            this._context = new MyContext();
            this._cotacaoApi = new CotacaoApi();
            
        }

        private IAtivoRepository _ativos;
        private IAporteRepository _aportes;
        private IProventoRepository _proventos;
        private IVendaRepository _vendas;
        private ICotacaoRepository _cotacoes;

        public IAtivoRepository Ativos => _ativos ?? (_ativos = new AtivoRepository(_context));
        public IAporteRepository Aportes => _aportes ?? (_aportes = new AporteRepository(_context));
        public IProventoRepository Proventos => _proventos ?? (_proventos = new ProventoRepository(_context));
        public IVendaRepository Vendas => _vendas ?? (_vendas = new VendaRepository(_context));
        public ICotacaoRepository Cotacoes => _cotacoes ??(_cotacoes = new CotacaoRepository(_context, _cotacaoApi));

        public void SaveChanges()
        {
            _context.SaveChanges();   
        }

        public void Rollback()
        {
            _ativos = null;
            _aportes = null;
            _proventos = null;
            _vendas = null;
            _cotacoes=null;
            _context = new MyContext();
        }
    }
}
