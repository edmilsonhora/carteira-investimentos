using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Ativo : EntityBase
    {
        public string Ticker { get; set; }
        public string CNPJ { get; set; }
        public TipoAtivo Tipo { get; set; }
        public int QtdTotal { get; set; }
        public decimal TotalInvestido { get; set; }
        public decimal PrecoMedio { get; set; }
        public decimal TotalProventos { get; set; }
        public decimal TotalResgatado { get; set; }
        public decimal SaldoAtual { get; set; }
        public  bool EhAtivo { get; set; }
        public List<Aporte> Aportes { get; set; }
        public List<Provento> Proventos { get; set; }
        public List<Venda> Vendas { get; set; }
        [NotMapped]
        public IRepository Repository { get; set; }            

        public override void Validar()
        {
            CampoTextoObrigatorio("Ticker", Ticker);
            CampoTextoObrigatorio("CNPJ", CNPJ);
            if (Repository.Ativos.JahExisteNaBaseDeDados(this))
            {
                RegrasQuebradas.Append($"O Ticker {Ticker} já existe na base de Dados.{Environment.NewLine}");
            }

            base.Validar();
        }

        public void AddAporte(Aporte aporte)
        {
            Aportes.Add(aporte);
            PrecoMedio = CalcularPrecoMedio();
            TotalInvestido += aporte.CalculaTotalAporte();
            QtdTotal += aporte.QtdCotas;
            CalculaSaldoAtual();
        }

        public void RemoveAporte(Aporte aporte)
        {
            Aportes.Remove(aporte);
            PrecoMedio = CalcularPrecoMedio();
            TotalInvestido -= aporte.CalculaTotalAporte();
            QtdTotal -= aporte.QtdCotas;
            CalculaSaldoAtual() ;
        }

        private decimal CalcularPrecoMedio()
        {           
            decimal precoPonderado = 0;
            int quantidades = 0;

            foreach (var item in Aportes)
            {
                precoPonderado += item.CalculaTotalAporte();
                quantidades += item.QtdCotas;
            }

            if(quantidades == 0) { return 0; }

            return (precoPonderado / quantidades);
        }

        public void AddProvento(Provento provento)
        {
            Proventos.Add(provento);
            TotalProventos += provento.CalculaTotalProvento();
        }

        public void RemoveProvento(Provento provento)
        {
            Proventos.Remove(provento);
            TotalProventos -= provento.CalculaTotalProvento();
        }

        public void AddVenda(Venda venda)
        {
            if (venda.QtdCotas > QtdTotal)
                throw new ApplicationException("Quantidade de venda maior que o Total.");

            Vendas.Add(venda);
            TotalResgatado += venda.CalculaTotalVenda();
            QtdTotal -= venda.QtdCotas;
            CalculaSaldoAtual();
            if (QtdTotal == 0)
            {
                PrecoMedio = 0;
                EhAtivo = false;
            }
        }

        public void RemoveVenda(Venda venda)
        {
            Vendas.Remove(venda);
            TotalResgatado -= venda.CalculaTotalVenda();
            QtdTotal += venda.QtdCotas;
            CalculaSaldoAtual();
        }

        public decimal CalculaPercentualNaCarteira(decimal totalInvestido)
        {
            return decimal.Divide(SaldoAtual, totalInvestido);
        }

        private void CalculaSaldoAtual()
        {
            SaldoAtual = decimal.Subtract(TotalInvestido, TotalResgatado);
        }
    }

    public interface IAtivoRepository : IRepositoryBase<Ativo>
    {
        bool JahExisteNaBaseDeDados(Ativo ativo);
        decimal ObterSaldoTotalInvestido();
    }
}
