using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.DomainModel
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
        public List<Aporte> Aportes { get; set; }
        public List<Provento> Proventos { get; set; }

        public override void Validar()
        {
            CampoTextoObrigatorio("Ticker", Ticker);
            CampoTextoObrigatorio("CNPJ", CNPJ);

            base.Validar();
        }

        public void AddAporte(Aporte aporte)
        {
            Aportes.Add(aporte);
            PrecoMedio = CalcularPrecoMedio();
            TotalInvestido += (aporte.VlCompra * aporte.QtdCompra);
            QtdTotal += aporte.QtdCompra;
        }

        public void RemoveAporte(Aporte aporte)
        {
            Aportes.Remove(aporte);
            PrecoMedio = CalcularPrecoMedio();
            TotalInvestido -= (aporte.VlCompra * aporte.QtdCompra);
            QtdTotal -= aporte.QtdCompra;
        }

        private decimal CalcularPrecoMedio()
        {           
            decimal precoPonderado = 0;
            int quantidades = 0;

            foreach (var item in Aportes)
            {
                precoPonderado += (item.VlCompra * item.QtdCompra);
                quantidades += item.QtdCompra;
            }

            if(quantidades == 0) { return 0; }

            return (precoPonderado / quantidades);
        }

        public void AddProvento(Provento provento)
        {
            Proventos.Add(provento);
            TotalProventos += provento.VlTotalProvento;
        }

        public void RemoveProvento(Provento provento)
        {
            Proventos.Remove(provento);
            TotalProventos -= provento.VlTotalProvento;
        }
    }

    public interface IAtivoRepository : IRepositoryBase<Ativo>
    {
        
    }
}
