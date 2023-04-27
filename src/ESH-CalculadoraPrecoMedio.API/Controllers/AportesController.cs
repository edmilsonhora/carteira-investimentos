using ESH_CalculadoraPrecoMedio.ApplicationService;
using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESH_CalculadoraPrecoMedio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AportesController : ControllerBase
    {
        private readonly IFacade _facade;
        public AportesController()
        {
            _facade = new Facade();
        }

        [HttpPost]
        [Route("salvar")]
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
    }
}
