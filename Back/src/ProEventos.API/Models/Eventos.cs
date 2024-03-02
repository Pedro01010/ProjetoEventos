using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProEventos.API.Models
{ 
    public class Eventos
    {
       [Key]
       public int EventoID{ get; set;} 
       public string Local { get; set; }
       public string Lote { get; set; }
       public string DataEvento { get; set; }
       public int QtdPessoas { get; set; }
       public string Tema { get; set; }
       public string ImagemURL { get; set; }

      
    }
}