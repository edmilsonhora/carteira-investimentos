using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.ApplicationService.Facades
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
            throw new NotImplementedException();
        }

        public ProventoView ObterPor(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProventoView> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(ProventoView view)
        {
            var novoProvento = new Provento();
            novoProvento.AtivoId = view.AtivoId;
            novoProvento.VlUnProvento = view.VlUnProvento;
            novoProvento.Data = view.Data;
            novoProvento.QtdCotas = view.QtdCotas;

            novoProvento.Validar();

            novoProvento.CalculaTotalProvento();

            var ativo = _repository.Ativos.ObterPor(view.AtivoId);
            ativo.AddProvento(novoProvento);
        }
    }
}
