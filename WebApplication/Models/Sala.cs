using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        [Required]
        public int numero { get; set; }
        [Required]
        public int Capacidade { get; set; }
        [Required]

        public string Descricao { get; set; }
        //Propriedade de Navegação
        List<Sessao> Sessoes { get; set; }    
    }
}