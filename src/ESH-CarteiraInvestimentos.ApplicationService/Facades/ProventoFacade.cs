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
    internal class ProventoFacade : IProventoFacade
    {
        private readonly IRepository _repository;

        public ProventoFacade(IRepository repository)
        {
            this._repository = repository;
        }

        public void Excluir(int id)
        {
            var provento = _repository.Proventos.ObterPor(id);
            if(provento is not null)
            {
                var ativo = _repository.Ativos.ObterPor(provento.AtivoId);
                ativo.RemoveProvento(provento);
                _repository.Proventos.Excluir(provento);
            }
        }

        public ProventoView ObterPor(int id)
        {
            return _repository.Proventos.ObterPor(id).ConvertToView();
        }

        public List<ProventoView> ObterTodos()
        {
            return _repository.Proventos.ObterTodos().ConvertToView();
        }

        public void Salvar(ProventoView view)
        {
            var novoProvento = new Provento();
            novoProvento.AtivoId = view.AtivoId;
            novoProvento.VlUnitario = view.VlUnProvento;
            novoProvento.Data = view.Data;
            novoProvento.QtdCotas = view.QtdCotas;

            novoProvento.Validar();

            var ativo = _repository.Ativos.ObterPor(view.AtivoId);
            ativo.AddProvento(novoProvento);
        }
    }
}
