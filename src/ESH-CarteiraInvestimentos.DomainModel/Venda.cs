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
        public int QtdVenda { get; set; }
        public DateTime DtVenda { get; set; }
        public decimal VlVenda { get; set; }

        public override void Validar()
        {
            CampoNumericoObrigatorio("AtivoId", AtivoId);
            CampoNumericoObrigatorio("Quantidade", QtdVenda);
            CampoDataObrigatorio("DtVenda", DtVenda);
            CampoNumericoObrigatorio("VlVenda", VlVenda);
            base.Validar();
        }
    }

    public interface IVendaRepository : IRepositoryBase<Venda> { }
}
