﻿using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using ESH_CalculadoraPrecoMedio.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.ApplicationService.Adapters
{
    internal static class AtivoAdapter
    {
        public static List<AtivoView> ConvertToView(this List<Ativo> list)
        {
            var novaLista = new List<AtivoView>();

            foreach (var ativo in list)
            {
                novaLista.Add(ativo.ConvertToView());
            }

            return novaLista;

        }

        public static AtivoView ConvertToView(this Ativo item)
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
            };
        }

    }
}