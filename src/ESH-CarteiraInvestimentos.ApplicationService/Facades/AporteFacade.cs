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
    internal class AporteFacade : IAporteFacade
    {
        private readonly IRepository _repository;
        public AporteFacade(IRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            var aporte = _repository.Aportes.ObterPor(id);
            if(aporte is not null)
            {
                var ativo = _repository.Ativos.ObterPor(aporte.AtivoId);
                ativo.RemoveAporte(aporte);
                _repository.Aportes.Excluir(aporte);
            }
        }

        public AporteView ObterPor(int id)
        {
            return _repository.Aportes.ObterPor(id).ConvertToView();
        }

        public List<AporteView> ObterTodos()
        {
            return _repository.Aportes.ObterTodos().ConvertToView();
        }

        public void Salvar(AporteView view)
        {
            var aporte = new Aporte();
            aporte.AtivoId = view.AtivoId;
            aporte.DtCompra = view.DtCompra;
            aporte.VlUnitario = view.VlCompra;
            aporte.QtdCotas = view.QtdCompra;

            aporte.Validar();

            var ativo = _repository.Ativos.ObterPor(view.AtivoId);
            ativo.AddAporte(aporte);
        }
    }
}
