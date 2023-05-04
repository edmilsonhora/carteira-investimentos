using ESH_CarteiraInvestimentos.ApplicationService.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESH_CarteiraInvestimentos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IFacade _facade;
        public VendasController(IFacade facade)
        {
            _facade = facade;
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _facade.Vendas.Excluir(id);
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
