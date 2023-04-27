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
        public Ativo()
        {
            Aportes = new List<Aporte>();
            Proventos = new List<Provento>();
        }
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
            CampoTextoObrigatorio("Ticket", Ticker);
            CampoTextoObrigatorio("CNPJ", CNPJ);

            base.Validar();
        }

        public void AddAporte(Aporte aporte)
        {
            Aportes.Add(aporte);
            PrecoMedio = aporte.CalcularPrecoMedio();
            TotalInvestido += (aporte.VlCompra * aporte.QtdCompra);
            QtdTotal += aporte.QtdCompra;
        }

        public void AddProvento(Provento provento)
        {
            Proventos.Add(provento);
            TotalProventos += provento.VlTotalProvento;
        }
    }

    public interface IAtivoRepository : IRepositoryBase<Ativo>
    {
        
    }
}
