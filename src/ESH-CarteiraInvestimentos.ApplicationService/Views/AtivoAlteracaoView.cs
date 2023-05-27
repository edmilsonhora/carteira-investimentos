using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class AtivoAtualizacaoView
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string CNPJ { get; set; }
        public Tipo Tipo { get; set; }
    }
}
