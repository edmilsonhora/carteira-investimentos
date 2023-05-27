using System;
using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Aporte : EntityBase
    {
        public int AtivoId { get; set; }
        public int QtdCotas { get; set; }
        public DateTime DtCompra { get; set; }
        public decimal VlUnitario { get; set; }

        public override void Validar()
        {
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
