using ESH_CarteiraInvestimentos.ApplicationService.Views;
using ESH_CarteiraInvestimentos.DomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacoesController : ControllerBase
    {
        private readonly IFacade _facade;
        public CotacoesController(IFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        [Route("obter-ultimas-cotacoes")]
        [ProducesResponseType(typeof(List<CotacaoView>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ObterUltimasCotacoes()
        {
            try
            {
                List<CotacaoView> lista = _facade.Cotacoes.ObterUltimasCotacoes();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.Replace(Environment.NewLine, ";"));
            }
        }
    }
}
