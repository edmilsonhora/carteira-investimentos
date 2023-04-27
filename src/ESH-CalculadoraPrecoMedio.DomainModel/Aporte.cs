using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ESH_CalculadoraPrecoMedio.DomainModel
{
    public class Aporte : EntityBase
    {
        public Ativo Ativo { get; set; }
        public int AtivoId { get; set; }
        public int QtdCompra { get; set; }
        public DateTime DtCompra { get; set; }
        public decimal VlCompra { get; set; }

        [NotMapped]
        public IAporteRepository Repository { get; set; }


        public override void Validar()
        {
            CampoNumericoObrigatorio("AtivoId", AtivoId);
            CampoNumericoObrigatorio("Quantidade", QtdCompra);
            CampoDataObrigatorio("DtCompra", DtCompra);
            CampoNumericoObrigatorio("VlCompra", VlCompra);
            base.Validar();
        }

        public decimal CalcularPrecoMedio()
        {           
            var lista = Repository.ObterAportesPor(AtivoId);
            decimal precoPonderado = (VlCompra * QtdCompra);
            int quantidades = QtdCompra;

            foreach (var item in lista)
            {
                precoPonderado += (item.VlCompra * item.QtdCompra);
                quantidades += item.QtdCompra;
            }

            return (precoPonderado / quantidades);

        }
    }

    public interface IAporteRepository : IRepositoryBase<Aporte>
    {
        List<Aporte> ObterAportesPor(int idAtivo);
    }
}
