
using ESH_CarteiraInvestimentos.ApplicationService;
using ESH_CarteiraInvestimentos.ApplicationService.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESH_CarteiraInvestimentos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AportesController : ControllerBase
    {
        private readonly IFacade _facade;
        public AportesController(IFacade facade)
        {
            _facade = facade;
        }

        [HttpPost]
        [Route("salvar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Salvar(AporteView aporte)
        {
            try
            {
                _facade.Aportes.Salvar(aporte);
                _facade.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.Replace(Environment.NewLine, ";"));
                 
            }
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Excluir(int id)
        {
            try
            {
                _facade.Aportes.Excluir(id);
                _facade.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.Replace(Environment.NewLine, ";"));

            }
        }
    }
}
