﻿using System;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Venda : EntityBase
    {
        public int AtivoId { get; set; }
        public int QtdCotas { get; set; }
        public DateTime DtVenda { get; set; }
        public decimal VlUnitario { get; set; }

        public override void Validar()
        {
            CampoNumericoObrigatorio("QtdCotas", QtdCotas);
            CampoDataObrigatorio("DtVenda", DtVenda);
            CampoNumericoObrigatorio("VlUnitario", VlUnitario);
            base.Validar();
        }
        public decimal CalcularTotalVenda()
        {
            return decimal.Multiply(VlUnitario, QtdCotas);
        }
        public void ValidaSePodeSerRealizada(int ativoQtdCotas)
        {
            if (QtdCotas > ativoQtdCotas)
            {
                throw new ApplicationException("Quantidade de venda maior que o total de cotas do ativo.");
            }
        }
    }

    public interface IVendaRepository : IRepositoryBase<Venda> { }
}
