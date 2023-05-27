namespace ESH_CarteiraInvestimentos.DomainModel
{
    public interface IRepository
    {
        IAtivoRepository Ativos { get; }
        IAporteRepository Aportes { get; }
        IProventoRepository Proventos { get; }
        IVendaRepository Vendas { get; }
        ICotacaoRepository Cotacoes { get; }

        void SaveChanges();
        void Rollback();
    }
}
