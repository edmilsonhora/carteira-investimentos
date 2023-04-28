using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Adapters
{
    public static class ProventoAdapter
    {
        public static List<ProventoView> ConvertToView(this List<Provento> list)
        {
            var novaLista = new List<ProventoView>();

            foreach (var provento in list)
            {
                novaLista.Add(provento.ConvertToView());
            }

            return novaLista;
        }

        public static ProventoView ConvertToView(this Provento item)
        {
            return new ProventoView()
            {
                Id = item.Id,
                AtivoId = item.AtivoId,
                Data = item.Data,
                QtdCotas = item.QtdCotas,
                VlUnProvento = item.VlUnProvento
            };
        }
    }

}
