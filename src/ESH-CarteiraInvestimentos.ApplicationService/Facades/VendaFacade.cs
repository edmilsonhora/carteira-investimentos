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
            throw new NotImplementedException();
        }

        public VendaView ObterPor(int id)
        {
            throw new NotImplementedException();
        }

        public List<VendaView> ObterTodos()
        {
            throw new NotImplementedException();
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
