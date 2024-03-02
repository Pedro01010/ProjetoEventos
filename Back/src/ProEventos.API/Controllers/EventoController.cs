using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       
        private readonly ILogger<EventoController> _logger;
        private readonly DataContext context;

        public EventoController(DataContext context){
            this.context = context;
        }
       [HttpGet]
        public IEnumerable<Eventos> Get()
        {
           return context.Eventos;
           
          
        }
        
        [HttpGet("{Id}")]
        public Eventos GetById(int Id)
        {
           
            return context.Eventos.FirstOrDefault(id => id.EventoID == Id);
              
        }
    }
}
