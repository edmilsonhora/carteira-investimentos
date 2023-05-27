using System;
using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class CotacaoView
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public Decimal Preco { get; set; }
        public DateTime Data { get; set; }
    }

    public interface ICotacaoFacade : IFacadeBase<CotacaoView>
    {
        List<CotacaoView> ObterUltimasCotacoes();
    }
}
