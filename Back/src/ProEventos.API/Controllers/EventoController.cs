using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Eventos> _evento =  new Eventos[]{
            new Eventos () {
            EventoID = 1,
            Tema = "Showw do Alok",
            Local = "Anápolis",
            Lote = "1º",
            QtdPessoas = 1000,
            DataEvento = DateTime.Now.AddDays(30).ToString(),
            ImagemURL = "foto.png"
           },
             new Eventos () {
            EventoID = 2,
            Tema = "Bam Bam vs Pópó",
            Local = "Sao Paulo",
            Lote = "1º",
            QtdPessoas = 1000,
            DataEvento = DateTime.Now.AddDays(30).ToString(),
            ImagemURL = "foto.png"
           }
           };
        private readonly ILogger<EventoController> _logger;
        
        public EventoController(){

        }
       [HttpGet]
        public IEnumerable<Eventos> Get()
        {
           return _evento;
           
          
        }
        
        [HttpGet("{Id}")]
        public IEnumerable<Eventos> GetById(int Id)
        {
           
            return _evento.Where(id => id.EventoID == Id);
              
        }
    }
}
