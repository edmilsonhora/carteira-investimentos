using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.ApplicationService.Facades
{
    internal class AporteFacade : IAporteFacade
    {
        private IRepository _repository;
        public AporteFacade(IRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public AporteView ObterPor(int id)
        {
            throw new NotImplementedException();
        }

        public List<AporteView> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(AporteView view)
        {
            var aporte = new Aporte();
            aporte.AtivoId = view.AtivoId;
            aporte.DtCompra = view.DtCompra;
            aporte.VlCompra = view.VlCompra;
            aporte.QtdCompra = view.QtdCompra;
            aporte.Repository = _repository.Aportes;

            aporte.Validar();

            var ativo = _repository.Ativos.ObterPor(view.AtivoId);
            ativo.AddAporte(aporte);
           

        }
    }
}
