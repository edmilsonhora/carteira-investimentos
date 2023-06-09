﻿using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.ApplicationService.Adapters
{
    internal static class AporteAdapter
    {
        public static List<AporteView> ConvertToView(this List<Aporte> list)
        {
            var novaLista = new List<AporteView>();
            foreach (var aporte in list)
            {
                novaLista.Add(aporte.ConvertToView());
            }

            return novaLista;
        }

        public static AporteView ConvertToView(this Aporte item)
        {
            return new AporteView()
            {
                Id = item.Id,
                AtivoId = item.AtivoId,
                DtCompra = item.DtCompra,
                QtdCompra = item.QtdCotas,
                VlCompra = item.VlUnitario
            };
        }
    }
}
