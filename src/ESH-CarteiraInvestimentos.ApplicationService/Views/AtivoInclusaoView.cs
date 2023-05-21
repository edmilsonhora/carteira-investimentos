using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class AtivoInclusaoView
    {
        public string Ticker { get; set; }
        public string CNPJ { get; set; }
        public TipoAtivo Tipo { get; set; }
        public int QtdCompra { get; set; }
        public DateTime DtCompra { get; set; }
        public decimal VlCompra { get; set; }
    }
}
