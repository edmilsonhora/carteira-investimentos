using ESH_CarteiraInvestimentos.ApplicationService.Facades;
using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DataAccess;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService
{
    public class Facade : IFacade
    {
        private readonly IRepository _repository;
        public Facade()
        {
            _repository = new Repository();
        }

        private IAtivoFacade _ativos;
        private IAporteFacade _aportes;
        private IProventoFacade _proventos;
        private IVendaFacade _vendas;
        private ICotacaoFacade _cotacoes;

        public IAtivoFacade Ativos => _ativos ?? (_ativos = new AtivoFacade(_repository));
        public IAporteFacade Aportes => _aportes ?? (_aportes = new  AporteFacade(_repository));
        public IProventoFacade Proventos => _proventos ?? (_proventos = new ProventoFacade(_repository));
        public IVendaFacade Vendas => _vendas ?? (_vendas = new VendaFacade(_repository));
        public ICotacaoFacade Cotacoes => _cotacoes ?? (_cotacoes = new CotacaoFacade(_repository));

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        public void Rollback()
        {
            _ativos = null;
            _aportes = null;
            _proventos = null;
            _vendas = null;
            _repository.Rollback();
        }
    }
}
