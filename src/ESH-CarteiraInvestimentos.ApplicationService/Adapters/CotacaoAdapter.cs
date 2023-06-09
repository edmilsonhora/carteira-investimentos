﻿using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.ApplicationService.Adapters
{
    internal static class CotacaoAdapter
    {
        public static List<CotacaoView> ConvertToView(this List<Cotacao> list)
        {
            var novalista = new List<CotacaoView>();

            foreach (var item in list)
            {
                novalista.Add(item.ConvertToView());
            }

            return novalista;

        }

        public static CotacaoView ConvertToView(this Cotacao item)
        {
            return new CotacaoView()
            {
                Id = item.Id,
                Data = item.Data,
                Preco = item.Preco,
                Ticker = item.Ativo.Ticker,
            };
        }

    }
}
