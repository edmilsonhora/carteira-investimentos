using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Aporte : EntityBase
    {
        public Ativo Ativo { get; set; }
        public int AtivoId { get; set; }
        public int QtdCotas { get; set; }
        public DateTime DtCompra { get; set; }
        public decimal VlUnitario { get; set; }

        public override void Validar()
        {
            CampoNumericoObrigatorio("AtivoId", AtivoId);
            CampoNumericoObrigatorio("QtdCotas", QtdCotas);
            CampoDataObrigatorio("DtCompra", DtCompra);
            CampoNumericoObrigatorio("VlCompra", VlUnitario);
            base.Validar();
        }
        public decimal CalcularTotalAporte()
        {
            return decimal.Multiply(VlUnitario, QtdCotas);
        }
    }

    public interface IAporteRepository : IRepositoryBase<Aporte>
    {
        List<Aporte> ObterAportesPor(int idAtivo);
    }
}
