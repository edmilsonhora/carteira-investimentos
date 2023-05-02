﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Views
{
    public class VendaView
    {
        public int Id { get; set; }
        public int AtivoId { get; set; }
        public int QtdVenda { get; set; }
        public DateTime DtVenda { get; set; }
        public decimal VlVenda { get; set; }
    }

    public interface IVendaFacade : IFacadeBase<VendaView> { }
}
