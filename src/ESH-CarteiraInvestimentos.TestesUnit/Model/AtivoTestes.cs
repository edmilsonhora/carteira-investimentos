using ESH_CarteiraInvestimentos.DomainModel;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace ESH_CarteiraInvestimentos.TestesUnit.Model
{
    public class AtivoTestes
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
            

            var novoAporte = new Aporte();
            novoAporte.QtdCotas = 10;
            novoAporte.VlUnitario = 56.60m;

            ativo.AddAporte(novoAporte);
            
            Assert.True(ativo.PrecoMedio.Equals(56.60m));
            Assert.True(ativo.TotalInvestido.Equals(novoAporte.CalcularTotalAporte()));
            Assert.True(ativo.QtdCotas.Equals(10));
            Assert.True(ativo.SaldoAtual.Equals(ativo.TotalInvestido));
            Assert.True(ativo.GanhoPerda.Equals(0));

        }

        [Fact(DisplayName = "Ao adicionar novo provento deve calcular totalProventos")]
        public void Teste4()
        {
            var ativo = new Ativo();
            

            var novoProvento = new Provento();
            novoProvento.VlUnitario = 0.87m;
            novoProvento.QtdCotas = 100;

            ativo.AddProvento(novoProvento);

            
            Assert.True(ativo.TotalProventos.Equals(87.00m));
        }

        [Fact(DisplayName = "Ao adicionar uma venda deve lançar exception se venda não pode ser realizada")]
        public void Teste5()
        {
            var ativo = new Ativo();
            ativo.QtdCotas = 30;
            

            var novaVenda = new Venda();
            novaVenda.VlUnitario = 0.87m;
            novaVenda.QtdCotas = 100;

            var result = Assert.Throws<ApplicationException>(() => ativo.AddVenda(novaVenda));

            Assert.Equal("Quantidade de venda maior que o total de cotas do ativo.", result.Message);

        }

        [Fact(DisplayName = "Ao adicionar uma venda deve calcular qtdCotas, totalResgatado e ganhoPerda")]
        public void Teste6()
        {
            var ativo = ObterAtivoComValores();            

            var novaVenda = new Venda();
            novaVenda.VlUnitario = 80.00m;
            novaVenda.QtdCotas = 10;

            ativo.AddVenda(novaVenda);
           
            Assert.True(ativo.QtdCotas.Equals(90));
            Assert.True(ativo.TotalResgatado.Equals(800.00m));
            Assert.True(ativo.GanhoPerda.Equals(-1800.00m));

        }

        [Fact(DisplayName = "Ao adicionar nova cotação deve setar cotacaoAtual e calcular ganhoPerda")]
        public void Teste7()
        {
            var ativo = ObterAtivoComValores();

            var novaCotacao = new Cotacao();
            novaCotacao.Preco = 80.00m;

            ativo.AddCotacao(novaCotacao);

            Assert.True(ativo.CotacaoAtual.Equals(80.00m));
            Assert.True(ativo.GanhoPerda.Equals(-2000.00m));
        }

        [Fact(DisplayName = "Calcula percentual do ativo na carteira")]
        public void Teste8()
        {
            var ativo = ObterAtivoComValores();
            var percentual = ativo.CalculaPercentualNaCarteira(100000.00m);

            Assert.True(percentual.ToString("P2").Equals("10,00%"));
        }

        [Fact(DisplayName = "Ao remover um aporte deve calcular precoMedio, totalInvestido, qtdCotas, saldoAtual e ganhoPerda")]
        public void Teste9()
        {
            var ativo = new Ativo();
            ativo.CotacaoAtual = 55.00m;
           

            var aporte1 = new Aporte();
            aporte1.QtdCotas = 10;
            aporte1.VlUnitario = 60.00m;
            ativo.AddAporte(aporte1);

            var aporte2 = new Aporte();
            aporte2.QtdCotas = 10;
            aporte2.VlUnitario = 50.00m;
            ativo.AddAporte(aporte2);

            ativo.RemoveAporte(aporte2);

            
            Assert.True(ativo.PrecoMedio.Equals(60.00m));
            Assert.True(ativo.TotalInvestido.Equals(600.00m));
            Assert.True(ativo.QtdCotas.Equals(10));
            Assert.True(ativo.SaldoAtual.Equals(ativo.TotalInvestido));
            Assert.True(ativo.GanhoPerda.Equals(-50));

        }

        [Fact(DisplayName = "Ao remover um provento deve calcular totalProventos")]
        public void Teste10()
        {
            var ativo = new Ativo();
           

            var provento1 = new Provento();
            provento1.VlUnitario = 0.87m;
            provento1.QtdCotas = 100;
            ativo.AddProvento(provento1);

            var provento2 = new Provento();
            provento2.VlUnitario = 0.87m;
            provento2.QtdCotas = 100;
            ativo.AddProvento(provento2);

            ativo.RemoveProvento(provento2);

           
            Assert.True(ativo.TotalProventos.Equals(87.00m));
        }

        [Fact(DisplayName = "Ao remover uma venda deve calcular qtdCotas, totalResgatado e ganhoPerda")]
        public void Teste11()
        {
            var ativo = ObterAtivoComValores();
           

            var venda1 = new Venda();
            venda1.VlUnitario = 80.00m;
            venda1.QtdCotas = 10;
            ativo.AddVenda(venda1);

            var venda2 = new Venda();
            venda2.VlUnitario = 80.00m;
            venda2.QtdCotas = 10;
            ativo.AddVenda(venda2);

            ativo.RemoveVenda(venda2);

           
            Assert.True(ativo.QtdCotas.Equals(90));
            Assert.True(ativo.TotalResgatado.Equals(800.00m));
            Assert.True(ativo.GanhoPerda.Equals(-1800.00m));
        }

        private Ativo ObterAtivoComValores()
        {
            return new Ativo()
            {
                TotalInvestido = 10000.00m,
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
