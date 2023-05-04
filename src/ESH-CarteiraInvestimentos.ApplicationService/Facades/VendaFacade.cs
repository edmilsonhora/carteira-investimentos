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
    internal class VendaFacade : IVendaFacade
    {
        private readonly IRepository _repository;

        public VendaFacade(IRepository repository)
        {
            this._repository = repository;
        }
        public void Excluir(int id)
        {
            var venda = _repository.Vendas.ObterPor(id);
            if(venda != null)
            {
                var ativo = _repository.Ativos.ObterPor(id);
                ativo.RemoveVenda(venda);
                _repository.Vendas.Excluir(venda);
            }
        }

        public VendaView ObterPor(int id)
        {
            return _repository.Vendas.ObterPor(id).ConvertToView();
        }

        public List<VendaView> ObterTodos()
        {
            return _repository.Vendas.ObterTodos().ConvertToView();
        }

        public void Salvar(VendaView view)
        {
            var venda = new Venda();
            venda.DtVenda = view.DtVenda;
            venda.QtdVenda = view.QtdVenda;
            venda.VlVenda = view.VlVenda;
            venda.AtivoId = view.AtivoId;

            venda.Validar();

            var ativo = _repository.Ativos.ObterPor(view.AtivoId);
            ativo.AddVenda(venda);
        }
    }
}
