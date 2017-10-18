using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    [Table("TbSessao")]
    public class Sessao
    {
        [Key]
        public int Codigo { get; set; }
        [Required]

        public DateTime DataHoraInicio { get; set; }
        [Required]

        public DateTime DataHoraFim { get; set; }
        [Required]
        public decimal ValorInteira { get; set; }
        [Required]
        public decimal ValorMeia { get; set; }
        [Required]
        public bool Encerrada { get; set; }

        public int SalaId { get; set; }

        public Sala Sala { get; set; }

    }
}