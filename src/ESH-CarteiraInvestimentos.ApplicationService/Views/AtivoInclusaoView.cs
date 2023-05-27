using ESH_CarteiraInvestimentos.DomainModel;
using System;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class AtivoInclusaoView
    {
        public string Ticker { get; set; }
        public string CNPJ { get; set; }
        public Tipo Tipo { get; set; }
        public int QtdCompra { get; set; }
        public DateTime DtCompra { get; set; }
        public decimal VlCompra { get; set; }
    }
}
