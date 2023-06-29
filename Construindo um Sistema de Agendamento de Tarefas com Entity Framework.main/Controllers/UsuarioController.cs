using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsuarioController : ControllerBase
  {
    #region Obter data e hora atual

    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDataHora()
    {
      var obj = new
      {
        Data = DateTime.Now.ToLongDateString(),
        Hora = DateTime.Now.ToShortTimeString()
      };

      return Ok(obj);
    }
    #endregion

    #region  Apresentar nome

    [HttpGet("Apresentar/{Nome}")]
    public IActionResult Apresentar(string Nome)
    {
      var msg = $"Olá, {Nome} seja bem vindo!";

      return Ok(new { msg });
    }

    #endregion
  }
}