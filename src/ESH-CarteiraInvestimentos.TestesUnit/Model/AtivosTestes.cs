﻿using ESH_CarteiraInvestimentos.DomainModel;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ESH_CarteiraInvestimentos.TestesUnit.Model
{
    public class AtivosTestes
    {
        [Fact(DisplayName = "Ao validar ativo sem preencher os dados deve lançar exception")]
        public void Teste0()
        {
            var ativo = new Ativo();
            ativo.Repository = ObterRepository();

            _repository.Setup(p => p.Ativos.JahExisteNaBaseDeDados(It.IsAny<Ativo>())).Returns(false);

            Assert.Throws<ApplicationException>(() => ativo.Validar());
        }

        [Fact(DisplayName = "Ao validar ativo sem preencher os dados deve lançar exception e exibir mensagem personalizada")]
        public void Teste1()
        {
            var ativo = new Ativo();

            ativo.Repository = ObterRepository();
            _repository.Setup(p => p.Ativos.JahExisteNaBaseDeDados(It.IsAny<Ativo>())).Returns(false);

            var result = Assert.Throws<ApplicationException>(() => ativo.Validar());

            var mensagens = result.Message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.Equal("O campo Ticker é obrigatório.", mensagens[0]);
            Assert.Equal("O campo CNPJ é obrigatório.", mensagens[1]);
        }

        [Fact(DisplayName = "Ao validar ativo com Ticker já existente deve lançar exception exibir mensagem personalizada")]
        public void Teste2()
        {
            var ativo = new Ativo();
            ativo.Ticker = "FUND11";
            ativo.CNPJ = "0000000000000";

            ativo.Repository = ObterRepository();
            _repository.Setup(p => p.Ativos.JahExisteNaBaseDeDados(It.IsAny<Ativo>())).Returns(true);

            var result = Assert.Throws<ApplicationException>(() => ativo.Validar());

            var mensagens = result.Message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.Equal($"O Ticker {ativo.Ticker} já existe na base de Dados.", mensagens[0]);

        }

        [Fact(DisplayName = "Ao adicionar novo aporte deve calcular precoMedio, totalInvestido, qtdCotas, saldoAtual e ganhoPerda")]
        public void Teste3()
        {
            var ativo = new Ativo();
            ativo.CotacaoAtual = 56.60m;
            ativo.Aportes = new List<Aporte>();

            var novoAporte = new Aporte();
            novoAporte.QtdCotas = 10;
            novoAporte.VlUnitario = 56.60m;

            ativo.AddAporte(novoAporte);

            Assert.True(ativo.Aportes.Count.Equals(1));
            Assert.True(ativo.PrecoMedio.Equals(56.60m));
            Assert.True(ativo.TotalInvestido.Equals(novoAporte.CalculaTotalAporte()));
            Assert.True(ativo.SaldoAtual.Equals(ativo.TotalInvestido));
            Assert.True(ativo.GanhoPerda.Equals(0));

        }

        [Fact(DisplayName = "Ao adicionar novo provento deve calcular totalProventos")]
        public void Teste4()
        {
            var ativo = new Ativo();
            ativo.Proventos = new List<Provento>();

            var novoProvento = new Provento();
            novoProvento.VlUnitario = 0.87m;
            novoProvento.QtdCotas = 100;

            ativo.AddProvento(novoProvento);

            Assert.True(ativo.Proventos.Count.Equals(1));
            Assert.True(ativo.TotalProventos.Equals(novoProvento.CalculaTotalProvento()));
        }

        [Fact(DisplayName = "Ao adicionar uma venda deve lançar exception se venda não pode ser realizada")]
        public void Teste5()
        {
            var ativo = new Ativo();
            ativo.QtdCotas = 30;
            ativo.Vendas = new List<Venda>();

            var novaVenda = new Venda();
            novaVenda.VlUnitario = 0.87m;
            novaVenda.QtdCotas = 100;

            var result = Assert.Throws<ApplicationException>(() => ativo.AddVenda(novaVenda));

            Assert.Equal("Quantidade de venda maior que o Total.", result.Message);

        }

        [Fact(DisplayName = "Ao adicionar uma venda deve calcular qtdCotas, totalResgatado e ganhoPerda")]
        public void Teste6()
        {
            var ativo = ObterAtivoComAportes();
            ativo.Vendas = new List<Venda>();

            var novaVenda = new Venda();
            novaVenda.VlUnitario = 80.00m;
            novaVenda.QtdCotas = 10;

            ativo.AddVenda(novaVenda);

            Assert.True(ativo.Vendas.Count.Equals(1));
            Assert.True(ativo.QtdCotas.Equals(90));
            Assert.True(ativo.TotalResgatado.Equals(800.00m));
            Assert.True(ativo.GanhoPerda.Equals(-1800.00m));

        }

        [Fact(DisplayName = "Ao adicionar nova cotação deve setar cotacaoAtual e calcular ganhoPerda")]
        public void Teste7()
        {
            var ativo = ObterAtivoComAportes();
            ativo.Cotacoes = new List<Cotacao>();

            var novaCotacao = new Cotacao();
            novaCotacao.Preco = 80.00m;

            ativo.AddCotacao(novaCotacao);

            Assert.True(ativo.CotacaoAtual.Equals(80.00m));
            Assert.True(ativo.GanhoPerda.Equals(-2000.00m));
        }

        [Fact(DisplayName = "Calcula percentual do ativo na carteira")]
        public void Teste8()
        {
            var ativo = ObterAtivoComAportes();
            var percentual = ativo.CalculaPercentualNaCarteira(100000.00m);

            Assert.True(percentual.ToString("P2").Equals("10,00%"));
        }

        private Ativo ObterAtivoComAportes()
        {
            return new Ativo()
            {
                QtdCotas = 100,
                SaldoAtual = 10000.00m,
                PrecoMedio = 100.00m,
                CotacaoAtual = 80.00m
            };
        }

        private IRepository ObterRepository()
        {
            return _repository.Object;
        }


        private readonly Mock<IRepository> _repository = new();
    }
}
