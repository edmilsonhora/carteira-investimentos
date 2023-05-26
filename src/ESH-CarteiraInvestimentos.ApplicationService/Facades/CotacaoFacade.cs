using ESH_CarteiraInvestimentos.ApplicationService.Adapters;
using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Facades
{
    internal class CotacaoFacade : ICotacaoFacade
    {
        private readonly IRepository _repository;
        public CotacaoFacade(IRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public CotacaoView ObterPor(int id)
        {
            throw new NotImplementedException();
        }

        public List<CotacaoView> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public List<CotacaoView> ObterUltimasCotacoes()
        {
            return _repository.Cotacoes.ObterUltimasCotacoes().ConvertToView();
        }

        public void Salvar(CotacaoView view)
        {
            throw new NotImplementedException();
        }
    }
}
