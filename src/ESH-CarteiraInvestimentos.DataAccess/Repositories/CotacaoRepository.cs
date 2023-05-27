using ESH_CarteiraInvestimentos.DataAccess.Contexts;
using ESH_CarteiraInvestimentos.DataAccess.RestApis;
using ESH_CarteiraInvestimentos.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ESH_CarteiraInvestimentos.DataAccess.Repositories
{
    internal class CotacaoRepository : AbstractRepository<Cotacao>, ICotacaoRepository
    {
        private readonly MyContext _context;
        private readonly CotacaoApi _api;
        private int contador = 0;
        public CotacaoRepository(MyContext contexto, CotacaoApi api) : base(contexto)
        {
            _context = contexto;
            _api = api;
        }
        public List<Cotacao> ObterUltimasCotacoes()
        {
            contador++;
            if (contador > 3)
            {
                throw new ArgumentException("Quantidade de tentativas de atualizar cotações excedida.");
            }

            if (CotacoesEstaoAtualizadas())
            {
                return _context.Cotacoes.Include(p => p.Ativo).Where(p => p.DataInclusao.Date == DateTime.Now.Date).AsNoTracking().ToList();
            }
            else
            {
                var tickers = _context.Ativos.Where(p => p.EhAtivo).Select(p => p.Ticker).ToArray();
                var tickersStr = string.Join(",", tickers);
                CotacaoDTO dto = _api.ObterCotacoes(tickersStr);
                if (dto.results.Any())
                {
                    foreach (var item in dto.results)
                    {
                        var novaCotacao = ObterNovaCotacao(item);
                        novaCotacao.Validar();
                        var ativo = _context.Ativos.Include(p => p.Cotacoes).First(p => p.Ticker == item.Ticker.ToUpper() && p.EhAtivo);
                        ativo.AddCotacao(novaCotacao);
                        _context.SaveChanges();
                    }
                }
                return ObterUltimasCotacoes();
            }
        }

        private Cotacao ObterNovaCotacao(Result item)
        {
            return new Cotacao()
            {
                Data = item.Data,
                Preco = item.Preco,
                DataInclusao = DateTime.Now,
            };

        }
        private bool CotacoesEstaoAtualizadas()
        {
            return _context.Cotacoes.Any(p => p.DataInclusao.Date == DateTime.Now.Date);
        }
    }
}
