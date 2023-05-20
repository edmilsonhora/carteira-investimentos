using ESH_CarteiraInvestimentos.DomainModel;
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
        [Fact(DisplayName = "Ao tentar salvar ativo sem preencher os dados deve lançar exception")]
        public void Teste0()
        {
            var ativo = new Ativo();

            ativo.Repository = _repository.Object;
            _repository.Setup(p => p.Ativos.JahExisteNaBaseDeDados(It.IsAny<Ativo>())).Returns(false);

            Assert.Throws<ApplicationException>(() => ativo.Validar());
        }

        [Fact(DisplayName = "Ao tentar salvar um ativo deve validar os campos")]
        public void Teste1()
        {
            var ativo = new Ativo();

            ativo.Repository = _repository.Object;
            _repository.Setup(p => p.Ativos.JahExisteNaBaseDeDados(It.IsAny<Ativo>())).Returns(false);

            var result = Assert.Throws<ApplicationException>(() => ativo.Validar());
            
            var mensagens = result.Message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.Equal("O campo Ticker é obrigatório.", mensagens[0]);
            Assert.Equal("O campo CNPJ é obrigatório.", mensagens[1]);
        }

        [Fact(DisplayName = "Ao salvar um ativo com Ticker já existente deve validar duplicidade")]
        public void Teste2()
        {
            var ativo = new Ativo();
            ativo.Ticker = "LGCP11";
            ativo.CNPJ = "0000000000000";

            ativo.Repository = _repository.Object;
            _repository.Setup(p => p.Ativos.JahExisteNaBaseDeDados(It.IsAny<Ativo>())).Returns(true);

            var result = Assert.Throws<ApplicationException>(() => ativo.Validar());

            var mensagens = result.Message.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            
            Assert.Equal($"O Ticker {ativo.Ticker} já existe na base de Dados.", mensagens[0]);

        }

        [Fact(DisplayName = "Ao adicionar um Aporte deve calcular precoMedio, totalInvestido e qtdTotal")]
        public void Teste3()
        {
            var ativo = new Ativo();
            ativo.Aportes = new List<Aporte>();

            var novoAporte = new Aporte();
            novoAporte.QtdCompra = 10;
            novoAporte.DtCompra = DateTime.Now;
            novoAporte.VlCompra = 56.60m;
            

            ativo.AddAporte(novoAporte);

            Assert.True(ativo.Aportes.Count.Equals(1));
            Assert.True(ativo.PrecoMedio.Equals(56.60m));
            Assert.True(ativo.TotalInvestido.Equals( decimal.Multiply(10, 56.60m)));
            
        }

        [Fact(DisplayName = "Ao adicionar um Provento deve calcular Total de Proventos")]
        public void Teste4()
        {
            var ativo = new Ativo();
            ativo.Aportes = new List<Aporte>();

            var novoAporte = new Aporte();
            novoAporte.QtdCompra = 10;
            novoAporte.DtCompra = DateTime.Now;
            novoAporte.VlCompra = 56.60m;

            ativo.AddAporte(novoAporte);

            Assert.True(ativo.Aportes.Count.Equals(1));
            Assert.True(ativo.PrecoMedio.Equals(56.60m));
        }



        private readonly Mock<IRepository> _repository = new();
    }
}
