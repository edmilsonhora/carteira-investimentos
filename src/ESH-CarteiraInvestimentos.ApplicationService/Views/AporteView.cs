using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class AporteView
    {
        public int Id { get; set; }
        public int AtivoId { get; set; }
        public int QtdCompra { get; set; }
        public DateTime DtCompra { get; set; }
        public decimal VlCompra { get; set; }
    }

    public interface IAporteFacade : IFacadeBase<AporteView> { }
}
