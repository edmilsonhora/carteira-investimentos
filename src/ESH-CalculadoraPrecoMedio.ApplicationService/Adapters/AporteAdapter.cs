using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.ApplicationService.Adapters
{
    public static class AporteAdapter
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
                QtdCompra = item.QtdCompra,
                VlCompra = item.VlCompra
            };
        }
    }
}
