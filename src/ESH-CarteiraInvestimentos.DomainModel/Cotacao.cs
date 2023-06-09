﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ESH_CarteiraInvestimentos.DomainModel
{
    public class Cotacao : EntityBase
    {
        public Ativo Ativo { get; set; }
        public int AtivoId { get; set; }
        public Decimal Preco { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataInclusao { get; set; }

        public override void Validar()
        {
            CampoDataObrigatorio("Data", Data);
            CampoNumericoObrigatorio("Preco", Preco);
            base.Validar();
        }
    }

    public class Result
    {
        [JsonPropertyName("symbol")]
        public string Ticker { get; set; }
        [JsonPropertyName("regularMarketPrice")]
        public decimal Preco { get; set; }
        [JsonPropertyName("regularMarketTime")]
        public DateTime Data { get; set; }
    }

    public class CotacaoDTO
    {
        public List<Result> results { get; set; }
        public DateTime requestedAt { get; set; }
    }

    public interface ICotacaoRepository : IRepositoryBase<Cotacao>
    {

        List<Cotacao> ObterUltimasCotacoes();
    }

    public interface ICotacaoApi
    {
        CotacaoDTO ObterCotacoes(string tikers);
    }
}
