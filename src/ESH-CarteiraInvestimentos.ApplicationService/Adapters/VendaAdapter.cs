using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.ApplicationService.Adapters
{
    internal static class VendaAdapter
    {
        public static List<VendaView> ConvertToView(this List<Venda> list)
        {
            var novaLista = new List<VendaView>();

            foreach (var item in list)
            {

                novaLista.Add(item.ConvertToView());
            }

            return novaLista;
        }

        public static VendaView ConvertToView(this Venda item)
        {
            return new VendaView()
            {
                Id = item.Id,
                AtivoId = item.AtivoId,
                DtVenda = item.DtVenda,
                QtdVenda = item.QtdCotas,
                VlVenda = item.VlUnitario
            };
        }
    }
}
