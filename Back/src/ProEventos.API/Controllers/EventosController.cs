using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class EventosController : ControllerBase
    {
       
      
        private readonly ProEventosContext _context;

        public EventosController(ProEventosContext context){
           _context = context;
        }
       [HttpGet]
        public IEnumerable<Eventos> Get()
        {
           return _context.Eventos;
           
          
        }
        
       
    }

}
