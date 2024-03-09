using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class EventosController : ControllerBase
    {
       
        private readonly ILogger<EventosController> _logger;
        private readonly DataContext _context;

        public EventosController(DataContext context){
           _context = context;
        }
       [HttpGet]
        public IEnumerable<Eventos> Get()
        {
           return _context.Eventos;
           
          
        }
        
       
    }
}
