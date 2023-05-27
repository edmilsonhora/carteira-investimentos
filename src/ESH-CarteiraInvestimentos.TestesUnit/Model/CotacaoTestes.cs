using ESH_CarteiraInvestimentos.DomainModel;
using System;
using Xunit;

namespace ESH_CarteiraInvestimentos.TestesUnit.Model
{
    public class CotacaoTestes
    {
        [Fact(DisplayName = "Ao validar cotacao sem preencher os dados deve lançar exception")]
        public void Teste0()
        {
            var cotacao = new Cotacao();

            Assert.Throws<ApplicationException>(() => cotacao.Validar());
        }

        [Fact(DisplayName = "Ao validar cotacao sem preencher os dados deve lançar exception e exibir mensagem personalizada")]
        public void Teste1()
        {
            var cotacao = new Cotacao();

            var result = Assert.Throws<ApplicationException>(() => cotacao.Validar());

            var mensagens = result.Message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);


            Assert.Equal("O campo Data é obrigatório.", mensagens[0]);
            Assert.Equal("O campo Preco é obrigatório.", mensagens[1]);
        }
    }
}
