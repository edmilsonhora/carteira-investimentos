using System;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Provento : EntityBase
    {
        public int AtivoId { get; set; }
        public DateTime Data { get; set; }
        public int QtdCotas { get; set; }
        public decimal VlUnitario { get; set; }
        public override void Validar()
        {
            CampoDataObrigatorio("Data", Data);
            CampoNumericoObrigatorio("QtdCotas", QtdCotas);
            CampoNumericoObrigatorio("VlProvento", VlUnitario);

            base.Validar();
        }
        public decimal CalcularTotalProvento()
        {
            return decimal.Multiply(VlUnitario, QtdCotas);
        }
    }

    public interface IProventoRepository : IRepositoryBase<Provento> { }
}
