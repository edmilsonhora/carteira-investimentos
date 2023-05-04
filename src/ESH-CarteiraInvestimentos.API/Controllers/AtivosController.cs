using ESH_CarteiraInvestimentos.ApplicationService;
using ESH_CarteiraInvestimentos.ApplicationService.Views;
using Microsoft.AspNetCore.Mvc;
using System;

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
        [Route("salvar")]
        public IActionResult Salvar(AtivoView ativo)
        {
            try
            {
                _facade.Ativos.Salvar(ativo);
                _facade.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.Replace(Environment.NewLine,";"));                
            }
        }

        [HttpGet]
        [Route("obterTodos")]
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
