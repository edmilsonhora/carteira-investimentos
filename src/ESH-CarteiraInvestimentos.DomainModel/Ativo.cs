using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Ativo : EntityBase
    {
        private List<Aporte> _aportes;
        private List<Venda> _vendas;
        private List<Provento> _proventos;
        private List<Cotacao> _cotacoes;

        public Ativo()
        {
            _proventos = new List<Provento>();
            _aportes = new List<Aporte>();
            _vendas = new List<Venda>();
            _cotacoes = new List<Cotacao>();
        }

        public string Ticker { get; set; }
        public string CNPJ { get; set; }
        public Tipo Tipo { get; set; }
        public int QtdCotas { get; set; }
        public decimal TotalInvestido { get; set; }
        public decimal PrecoMedio { get; set; }
        public decimal TotalProventos { get; set; }
        public decimal TotalResgatado { get; set; }
        public decimal SaldoAtual { get; set; }
        public bool EhAtivo { get; set; }
        public decimal CotacaoAtual { get; set; }
        public decimal GanhoPerda { get; set; }
        public IEnumerable<Aporte> Aportes { get { return _aportes; } private set { _aportes = value.ToList(); } }
        public IEnumerable<Provento> Proventos { get { return _proventos; } private set { _proventos = value.ToList(); } }
        public IEnumerable<Venda> Vendas { get { return _vendas; } private set { _vendas = value.ToList(); } }
        public IEnumerable<Cotacao> Cotacoes { get { return _cotacoes; } private set { _cotacoes = value.ToList(); } }
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
            _aportes.Add(aporte);
            PrecoMedio = CalcularPrecoMedio(aporte);
            TotalInvestido += aporte.CalcularTotalAporte();
            QtdCotas += aporte.QtdCotas;
            CalculaSaldoAtual();
            CalculaGanhoPerda();
        }
        public void RemoveAporte(Aporte aporte)
        {
            _aportes.Remove(aporte);
            PrecoMedio = RecalcularPrecoMedio(aporte);
            TotalInvestido -= aporte.CalcularTotalAporte();
            QtdCotas -= aporte.QtdCotas;
            CalculaSaldoAtual();
            CalculaGanhoPerda();
        }
        public void AddProvento(Provento provento)
        {
            _proventos.Add(provento);
            TotalProventos += provento.CalcularTotalProvento();
        }
        public void RemoveProvento(Provento provento)
        {
            _proventos.Remove(provento);
            TotalProventos -= provento.CalcularTotalProvento();
        }
        public void AddVenda(Venda venda)
        {
            venda.ValidaSePodeSerRealizada(QtdCotas);
            _vendas.Add(venda);
            TotalResgatado += venda.CalcularTotalVenda();
            QtdCotas -= venda.QtdCotas;
            CalculaSaldoAtual();
            CalculaGanhoPerda();
            if (QtdCotas == 0)
            {
                PrecoMedio = 0;
                EhAtivo = false;
            }
        }
        public void RemoveVenda(Venda venda)
        {
            _vendas.Remove(venda);
            TotalResgatado -= venda.CalcularTotalVenda();
            QtdCotas += venda.QtdCotas;
            CalculaSaldoAtual();
            CalculaGanhoPerda();
        }
        public void AddCotacao(Cotacao cotacao)
        {
            _cotacoes.Add(cotacao);
            CotacaoAtual = cotacao.Preco;
            CalculaGanhoPerda();
        }
        public decimal CalculaPercentualNaCarteira(decimal totalInvestido)
        {
            return decimal.Divide(SaldoAtual, totalInvestido);
        }
        #region metodosPrivados

        //private decimal CalcularPrecoMedio()
        //{
        //    decimal precoPonderado = 0;
        //    int quantidades = 0;

        //    foreach (var item in Aportes)
        //    {
        //        precoPonderado += item.CalcularTotalAporte();
        //        quantidades += item.QtdCotas;
        //    }

        //    if (quantidades == 0) { return 0; }

        //    return (precoPonderado / quantidades);
        //}

        private decimal CalcularPrecoMedio(Aporte aporte)
        {
            decimal precoPonderado = TotalInvestido;
            int quantidades = QtdCotas;

            precoPonderado += aporte.CalcularTotalAporte();
            quantidades += aporte.QtdCotas;

            if (quantidades == 0) { return 0; }

            return (precoPonderado / quantidades);

        }

        private decimal RecalcularPrecoMedio(Aporte aporte)
        {
            decimal precoPonderado = TotalInvestido;
            int quantidades = QtdCotas;

            precoPonderado -= aporte.CalcularTotalAporte();
            quantidades -= aporte.QtdCotas;

            if (quantidades == 0) { return 0; }

            return (precoPonderado / quantidades);

        }

        private void CalculaSaldoAtual()
        {
            SaldoAtual = decimal.Subtract(TotalInvestido, TotalResgatado);
        }

        private void CalculaGanhoPerda()
        {
            GanhoPerda = decimal.Subtract(decimal.Multiply(CotacaoAtual, QtdCotas), decimal.Multiply(PrecoMedio, QtdCotas));
        }

        #endregion
    }

    public interface IAtivoRepository : IRepositoryBase<Ativo>
    {
        bool JahExisteNaBaseDeDados(Ativo ativo);
        decimal ObterSaldoTotalInvestido();
    }
}
