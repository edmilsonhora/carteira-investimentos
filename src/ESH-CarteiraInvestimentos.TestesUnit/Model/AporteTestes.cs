﻿using ESH_CarteiraInvestimentos.DomainModel;
using System;
using Xunit;

namespace ESH_CarteiraInvestimentos.TestesUnit.Model
{
    public class AporteTestes
    {
        [Fact(DisplayName = "Ao validar aporte sem preencher os dados deve lançar exception")]
        public void Teste0()
        {
            var aporte = new Aporte();

            Assert.Throws<ApplicationException>(() => aporte.Validar());
        }

        [Fact(DisplayName = "Ao validar aporte sem preencher os dados deve lançar exception e exibir mensagem personalizada")]
        public void Teste1()
        {
            var aporte = new Aporte();

            var result = Assert.Throws<ApplicationException>(() => aporte.Validar());

            var mensagens = result.Message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);


            Assert.Equal("O campo QtdCotas é obrigatório.", mensagens[0]);
            Assert.Equal("O campo DtCompra é obrigatório.", mensagens[1]);
            Assert.Equal("O campo VlCompra é obrigatório.", mensagens[2]);
        }

        [Fact(DisplayName = "Calcular total do aporte")]
        public void Teste2()
        {
            var aporte = new Aporte();
            aporte.QtdCotas = 10;
            aporte.VlUnitario = 80.00m;

            var totalDaVenda = aporte.CalcularTotalAporte();

            Assert.True(totalDaVenda.Equals(800.00m));
        }
    }
}
