using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Venda : EntityBase
    {
        public Ativo Ativo { get; set; }
        public int AtivoId { get; set; }
        public int QtdCotas { get; set; }
        public DateTime DtVenda { get; set; }
        public decimal VlUnitario { get; set; }

        public override void Validar()
        {
            CampoNumericoObrigatorio("AtivoId", AtivoId);
            CampoNumericoObrigatorio("QtdCotas", QtdCotas);
            CampoDataObrigatorio("DtVenda", DtVenda);
            CampoNumericoObrigatorio("VlUnitario", VlUnitario);
            base.Validar();
        }

        public decimal CalculaTotalVenda()
        {
            return decimal.Multiply(VlUnitario, QtdCotas);
        }
    }

    public interface IVendaRepository : IRepositoryBase<Venda> { }
}
