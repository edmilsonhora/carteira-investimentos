using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public interface IFacade
    {
        IAtivoFacade Ativos { get; }
        IAporteFacade Aportes { get; }
        IProventoFacade Proventos { get; }
        IVendaFacade Vendas { get; }
        ICotacaoFacade Cotacoes { get; }
        void SaveChanges();
        void Rollback();
    }

    public interface IFacadeBase<T> where T : class
    {
        void Salvar(T view);
        void Excluir(int id);
        List<T> ObterTodos();
        T ObterPor(int id);
    }
}
