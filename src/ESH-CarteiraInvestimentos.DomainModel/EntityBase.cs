﻿using System;
using System.Text;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public abstract class EntityBase
    {
        protected StringBuilder RegrasQuebradas = new StringBuilder();
        public int Id { get; set; }
        protected void CampoTextoObrigatorio(string nome, string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                RegrasQuebradas.Append($"O campo {nome} é obrigatório.{Environment.NewLine}");
            }
        }
        protected void CampoNumericoObrigatorio(string nome, decimal valor)
        {
            if (valor <= 0)
            {
                RegrasQuebradas.Append($"O campo {nome} é obrigatório.{Environment.NewLine}");
            }
        }
        protected void CampoNumericoObrigatorio(string nome, int valor)
        {
            if (valor <= 0)
            {
                RegrasQuebradas.Append($"O campo {nome} é obrigatório.{Environment.NewLine}");
            }
        }
        protected void CampoDataObrigatorio(string nome, DateTime valor)
        {
            if (valor == DateTime.MinValue)
            {
                RegrasQuebradas.Append($"O campo {nome} é obrigatório.{Environment.NewLine}");
            }
        }
        protected void CampoDataObrigatorio(string nome, DateOnly valor)
        {
            if (valor == DateOnly.MinValue)
            {
                RegrasQuebradas.Append($"O campo {nome} é obrigatório.{Environment.NewLine}");
            }
        }
        public virtual void Validar()
        {
            if (RegrasQuebradas.Length > 0)
                throw new ApplicationException(RegrasQuebradas.ToString());
        }
    }
}
