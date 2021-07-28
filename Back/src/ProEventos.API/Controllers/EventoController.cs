using System;
using System.Collections.Generic;
using System.Linq;
using ProEventos.API.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){    
                EventoId = 1,
               Tema = "Angular",
               Local= "Se",
               Lote="1",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString(),
               imagemURL = "foto.png"
            },
            new Evento(){    
                EventoId = 2,
               Tema = "Angular",
               Local= "São Paulo",
               Lote="2",
               QtdPessoas = 300,
               DataEvento = DateTime.Now.AddDays(3).ToString(),
               imagemURL = "foto.png"
            }
           };
        public EventoController()
        {
         
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(e => e.EventoId == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

         [HttpPost]
        public String Post()
        {
           return "value";
        }
    }
}
