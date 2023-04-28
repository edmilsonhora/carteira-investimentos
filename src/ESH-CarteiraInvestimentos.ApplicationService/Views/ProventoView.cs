using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class ProventoView
    {
        public int Id { get; set; }
        public int AtivoId { get; set; }
        public DateTime Data { get; set; }
        public int QtdCotas { get; set; }
        public decimal VlUnProvento { get; set; }
    }

    public interface IProventoFacade : IFacadeBase<ProventoView> { }
}
