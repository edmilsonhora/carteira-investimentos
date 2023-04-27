﻿using ESH_CalculadoraPrecoMedio.ApplicationService;
using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ESH_CalculadoraPrecoMedio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtivosController : ControllerBase
    {
        private readonly IFacade _facade;
        public AtivosController()
        {
            _facade = new Facade();
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
