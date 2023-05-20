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
    internal class AtivoFacade : IAtivoFacade
    {
        private readonly IRepository _repository;
        public AtivoFacade(IRepository repository)
        {
            _repository = repository;
        }
        public void Excluir(int id)
        {
            var obj = _repository.Ativos.ObterPor(id);
            if(obj != null)
            {
                _repository.Ativos.Excluir(obj);
            }
        }
        public AtivoView ObterPor(int id)
        {
            decimal totalInvestido = _repository.Ativos.ObterSaldoTotalInvestido();
            return _repository.Ativos.ObterPor(id).ConvertToView(totalInvestido);
        }
        public List<AtivoView> ObterTodos()
        {
            decimal totalInvestido = _repository.Ativos.ObterSaldoTotalInvestido();
            return _repository.Ativos.ObterTodos().ConvertToView(totalInvestido);
        }
        public void Salvar(AtivoView view)
        {
            var obj = view.Id == 0 ? new Ativo() : _repository.Ativos.ObterPor(view.Id);
            obj.CNPJ = view.CNPJ;
            obj.Ticker = view.Ticker;
            obj.Tipo = view.Tipo;
            obj.Validar();

            _repository.Ativos.Salvar(obj);
        }
    }
}
