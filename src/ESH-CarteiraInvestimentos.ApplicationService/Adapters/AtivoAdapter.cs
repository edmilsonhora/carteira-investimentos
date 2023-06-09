﻿using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System.Collections.Generic;

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
                QtdTotal = item.QtdCotas,
                Tipo = item.Tipo,
                TotalInvestido = item.TotalInvestido,
                TotalProventos = item.TotalProventos,
                TotalResgatado = item.TotalResgatado,
                SaldoAtual = item.SaldoAtual,
                PercentualNaCarteira = item.CalculaPercentualNaCarteira(totalInvestido),
                GanhaPerde = item.GanhoPerda,
                CotacaoAtual = item.CotacaoAtual,
                SaldoInvestido = item.SaldoInvestido
            };
        }
    }
}
