using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ModuloAPI.Entities;
using ModuloAPI.Context;

namespace ModuloAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContatoController : ControllerBase
  {
    private readonly AgendaContext _context;

    public ContatoController(AgendaContext context)
    {
      this._context = context;
    }

    [HttpPost]
    public IActionResult Create(Contato contato)
    {
      _context.Add(contato);
      _context.SaveChanges();

      return Ok(contato);
    }
  }
}