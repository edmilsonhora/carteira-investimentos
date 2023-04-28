using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DataAccess.Repositories;
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
        public Repository()
        {
            this._context = new MyContext();
        }

        private IAtivoRepository _ativos;
        private IAporteRepository _aportes;
        private IProventoRepository _proventos;

        public IAtivoRepository Ativos => _ativos ?? (_ativos = new AtivoRepository(_context));
        public IAporteRepository Aportes => _aportes ?? (_aportes = new AporteRepository(_context));
        public IProventoRepository Proventos => _proventos ?? (_proventos = new ProventoRepository(_context));

        public void SaveChanges()
        {
            _context.SaveChanges();   
        }

        public void Rollback()
        {
            _ativos = null;
            _aportes = null;
            _proventos = null;
            _context = new MyContext();
        }
    }
}
