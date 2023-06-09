﻿using ESH_CarteiraInvestimentos.DomainModel;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class AtivoView
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string CNPJ { get; set; }
        public Tipo Tipo { get; set; }
        public int QtdTotal { get; set; }
        public decimal TotalInvestido { get; set; }
        public decimal PrecoMedio { get; set; }
        public decimal TotalProventos { get; set; }
        public decimal TotalResgatado { get; set; }
        public decimal SaldoAtual { get; set; }
        public decimal PercentualNaCarteira { get; set; }
        public decimal GanhaPerde { get; set; }
        public decimal CotacaoAtual { get; set; }
        public decimal SaldoInvestido { get; set; }
    }

    public interface IAtivoFacade : IFacadeBase<AtivoView>
    {
        void Salvar(AtivoInclusaoView view);
        void Salvar(AtivoAtualizacaoView view);
    }

}
