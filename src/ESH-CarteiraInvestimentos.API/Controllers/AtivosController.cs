using ESH_CarteiraInvestimentos.ApplicationService.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ESH_CarteiraInvestimentos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtivosController : ControllerBase
    {
        private readonly IFacade _facade;
        public AtivosController(IFacade facade)
        {
            _facade = facade;
        }


        [HttpPost]
        [Route("atualizar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Atualizar(AtivoAtualizacaoView ativo)
        {
            try
            {
                _facade.Ativos.Salvar(ativo);
                _facade.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.Replace(Environment.NewLine, ";"));
            }
        }

        [HttpPost]
        [Route("incluir")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Incluir(AtivoInclusaoView ativo)
        {
            try
            {
                _facade.Ativos.Salvar(ativo);
                _facade.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.Replace(Environment.NewLine, ";"));
            }
        }

        [HttpGet]
        [Route("obterTodos")]
        [ProducesResponseType(typeof(List<AtivoView>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ObterTodos()
        {
            try
            {
                return Ok(_facade.Ativos.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.Replace(Environment.NewLine, ";"));
            }
        }

    }
}
