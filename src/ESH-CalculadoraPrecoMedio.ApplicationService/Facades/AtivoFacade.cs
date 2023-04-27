using ESH_CalculadoraPrecoMedio.ApplicationService.Adapters;
using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.ApplicationService.Facades
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
            return _repository.Ativos.ObterPor(id).ConvertToView();
        }
        public List<AtivoView> ObterTodos()
        {
            return _repository.Ativos.ObterTodos().ConvertToView();
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
