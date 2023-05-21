using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.ApplicationService.Adapters
{
    internal static class AtivoAdapter
    {
        public static List<AtivoView> ConvertToView(this List<Ativo> list, decimal totalInvestido)
        {
            var novaLista = new List<AtivoView>();

            foreach (var ativo in list)
            {
                novaLista.Add(ativo.ConvertToView(totalInvestido));
            }

            return novaLista;

        }

        public static AtivoView ConvertToView(this Ativo item, decimal totalInvestido)
        {
            if (item == null) return new AtivoView();

            return new AtivoView()
            {
                Id = item.Id,
                Ticker = item.Ticker,
                CNPJ = item.CNPJ,
                PrecoMedio = item.PrecoMedio,
                QtdTotal = item.QtdTotal,
                Tipo = item.Tipo,
                TotalInvestido = item.TotalInvestido,
                TotalProventos = item.TotalProventos,
                TotalResgatado = item.TotalResgatado,
                SaldoAtual = item.SaldoAtual,
                PercentualNaCarteira = item.CalculaPercentualNaCarteira(totalInvestido)
            };
        }

    }
}
