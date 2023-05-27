using ESH_CarteiraInvestimentos.ApplicationService.Adapters;
using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;

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
            if (obj != null)
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
            throw new NotImplementedException();
        }

        public void Salvar(AtivoInclusaoView view)
        {
            var obj = new Ativo();
            obj.CNPJ = view.CNPJ;
            obj.Ticker = view.Ticker;
            obj.Tipo = view.Tipo;
            obj.Repository = _repository;            
            obj.Validar();

            var aporte = new Aporte();
            aporte.DtCompra = view.DtCompra;
            aporte.VlUnitario = view.VlCompra;
            aporte.QtdCotas = view.QtdCompra;
            aporte.Validar();

            obj.AddAporte(aporte);

            _repository.Ativos.Salvar(obj);
        }

        public void Salvar(AtivoAtualizacaoView view)
        {
            var obj = _repository.Ativos.ObterPor(view.Id);

            if (obj is null)
            {
                throw new ApplicationException("Ativo não encontrado.");
            }

            obj.CNPJ = view.CNPJ;
            obj.Ticker = view.Ticker;
            obj.Tipo = view.Tipo;
            obj.Repository = _repository;
            obj.Validar();

            _repository.Ativos.Salvar(obj);
        }
    }
}
