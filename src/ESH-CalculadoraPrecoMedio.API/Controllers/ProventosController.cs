using ESH_CalculadoraPrecoMedio.ApplicationService;
using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESH_CalculadoraPrecoMedio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProventosController : ControllerBase
    {
        private readonly IFacade _facade;
        public ProventosController()
        {
            this._facade = new Facade();
        }

        [HttpGet]
        [Route("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _facade.Proventos.Excluir(id);
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
